# read parameter
$apiVersion = $args[0]

# check if apiVersion is valid
if ($null -eq $apiVersion) {
    Write-Host "Please provide apiVersion as parameter"
    exit
}
# echo apiVersion
Write-Host "Build and Publish with apiVersion: $apiVersion"

# build with .NET6
dotnet build -c Release -p:Version=$apiVersion

# build project with release
# dotnet build .\src\Agravity.Public\Agravity.Public.csproj -c Release

# execute extract third party licenses
.\extract_thirdparty_licenses.bat

# build nuget package
nuget pack -Build -OutputDirectory out .\src\Agravity.Public\Agravity.Public.csproj -Version $apiVersion

# Set API Key (once)
# nuget setApiKey xyz

# promt to publish
Write-Host "Publish package in version $apiVersion? (y/n)"
$publish = Read-Host

# check if publish
if ($publish -eq "y") {
    # publish nuget package
    dotnet nuget push .\out\Agravity.Public."$apiVersion".nupkg -s https://api.nuget.org/v3/index.json
}

