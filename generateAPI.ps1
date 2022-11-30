# read parameter
$apiVersion = $args[0]

# check if apiVersion is valid
if ($null -eq $apiVersion) {
    Write-Host "Please provide apiVersion as parameter"
    exit
}
# echo apiVersion
Write-Host "Generate API with apiVersion: $apiVersion"

# fully remove folder src
Remove-Item -Path .\src -Recurse -Force

# generate API
npx @openapitools/openapi-generator-cli generate -i http://localhost:7072/api/openapi/v3.json -g csharp-netcore -o . --additional-properties=packageName=Agravity.Public,library=httpclient,targetFramework=netstandard2.0,packageVersion=$apiVersion

#change directory to src
Set-Location .\src
# replace all "Dictionary>" with "Dictionary<string, object>>"
Get-ChildItem -Recurse -File | ForEach-Object { (Get-Content $_.FullName) -replace "Dictionary>", "Dictionary<string, object>>" | Set-Content $_.FullName }

#replace all "Dictionary&gt;" with "Dictionary&lt;string, object&gt;&gt;"
Get-ChildItem -Recurse -File | ForEach-Object { (Get-Content $_.FullName) -replace "Dictionary&gt;", "Dictionary&lt;string, object&gt;&gt;" | Set-Content $_.FullName }

# go one directory up
Set-Location ..

# git discard all neccessary files

# git discard files
git checkout -- .\Agravity.Public.sln
git checkout -- .\extract_thirdparty_licenses.bat
git checkout -- .\icon.png
git checkout -- .\nuget.exe
git checkout -- .\openapitools.json
git checkout -- .\src\Agravity.Public\Agravity.Public.nuspec
git checkout -- .\src\Agravity.Public\Agravity.Public.csproj

#replace old version with new version in csproj file
$csproj = Get-Content .\src\Agravity.Public\Agravity.Public.csproj
$csproj = $csproj -replace "<Version>.*</Version>", "<Version>$apiVersion</Version>"
$csproj | Set-Content .\src\Agravity.Public\Agravity.Public.csproj
