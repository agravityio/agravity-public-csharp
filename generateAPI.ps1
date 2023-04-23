# check REST API endpoint /version if backend is running, catch it and if it is not running: exit
$version = (Invoke-RestMethod -Uri http://localhost:7072/api/version -Method Get -ContentType "application/json" -ErrorAction SilentlyContinue)
if ($null -eq $version) {
    Write-Host "Please start backend before generating API"
    exit
}

$apiVersion = $version.version

# check if apiVersion is valid
if ($null -eq $apiVersion) {
    Write-Host "Please provide apiVersion as parameter"
    exit
}
# echo apiVersion
Write-Host "Generate API with apiVersion: $apiVersion"

# wait for user input
Write-Host "Press any key to continue ..."
$null = $Host.UI.RawUI.ReadKey("NoEcho,IncludeKeyDown")

Write-Host "Delete folder .\src"

# delete folder .\src without error output
Remove-Item -Path .\src -Recurse -Force -ErrorAction SilentlyContinue

Write-Host "Calling public API"
exit 0
# generate API
$params="packageName=Agravity.Public,library=httpclient,targetFramework=netstandard2.0,packageVersion="+$apiVersion
# Write-Host("Executing: openapi-generator generate -i https://api.agravity.com/v2/swagger.json -g csharp-netcore -o src -p "+$params);
npx @openapitools/openapi-generator-cli generate -i http://localhost:7072/api/openapi/v3.json -g csharp-netcore -o . --additional-properties=$params

#change directory to src
Set-Location .\src
# replace all "Dictionary>" with "Dictionary<string, object>>"
Get-ChildItem -Recurse -File | ForEach-Object { (Get-Content $_.FullName) -replace "Dictionary>", "Dictionary<string, object>>" | Set-Content $_.FullName }

# replace all "Dictionary<string, Object>" with "Dictionary<string, object>"
Get-ChildItem -Recurse -File | ForEach-Object { (Get-Content $_.FullName) -replace "Dictionary<string, Object>", "Dictionary<string, object>" | Set-Content $_.FullName }

#replace all "Dictionary&gt;" with "Dictionary&lt;string, object&gt;&gt;"
Get-ChildItem -Recurse -File | ForEach-Object { (Get-Content $_.FullName) -replace "Dictionary&gt;", "Dictionary&lt;string, object&gt;&gt;" | Set-Content $_.FullName }

# go one directory up
Set-Location ..

# git discard all neccessary files

# git discard files
git checkout -- .\.gitignore
git checkout -- .\generateAPI.ps1
git checkout -- .\Agravity.Public.sln
git checkout -- .\extract_thirdparty_licenses.bat
git checkout -- .\icon.png
git checkout -- .\nuget.exe
git checkout -- .\openapitools.json
git checkout -- .\src\Agravity.Public\Agravity.Public.nuspec
git checkout -- .\src\Agravity.Public\Agravity.Public.csproj
git checkout -- .\src\Agravity.Public\THIRD-PARTY-NOTICES.TXT

#replace old version with new version in csproj file
$csproj = Get-Content .\src\Agravity.Public\Agravity.Public.csproj
$csproj = $csproj -replace "<Version>.*</Version>", "<Version>$apiVersion</Version>"
$csproj | Set-Content .\src\Agravity.Public\Agravity.Public.csproj

# echo apiVersion
Write-Host "Build and Publish with apiVersion: $apiVersion"

# build project with release
dotnet build .\src\Agravity.Public\Agravity.Public.csproj -c Release

# execute extract third party licenses
.\extract_thirdparty_licenses.bat

# build nuget package with version
#create command 
nuget pack -Build -OutputDirectory .\out .\src\Agravity.Public\Agravity.Public.csproj -Version $apiVersion

# Set API Key (once)
# nuget setApiKey xyz

# prompt to publish
Write-Host "Publish package in version $apiVersion? (y/n)"
$publish = Read-Host

# check if publish
if ($publish -eq "y") {
    # publish nuget package
    dotnet nuget push .\out\Agravity.Public."$apiVersion".nupkg -s https://api.nuget.org/v3/index.json
}