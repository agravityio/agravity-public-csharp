# read parameter
$apiVersion = $args[0]

# check if apiVersion is valid
if ($null -eq $apiVersion) {
    Write-Host "Please provide apiVersion as parameter"
    exit
}
# echo apiVersion
Write-Host "Update sample files with new apiVersion: $apiVersion"

#update packages.config with new apiVersion
$packagesConfig = Get-Content .\samples\NetFrameworkFormUpload\NetFrameworkFormUpload\packages.config
$packagesConfig = $packagesConfig -replace "<package id=""Agravity.Public"" version="".*"" targetFramework=""net472"" />", "<package id=""Agravity.Public"" version=""$apiVersion"" targetFramework=""net472"" />"
$packagesConfig | Set-Content .\samples\NetFrameworkFormUpload\NetFrameworkFormUpload\packages.config

#update csproj with new apiVersion
$csproj = Get-Content .\samples\AzureFunction40\AzureFunction40.csproj
$csproj = $csproj -replace "<PackageReference Include=""Agravity.Public"" Version="".*"" />", "<PackageReference Include=""Agravity.Public"" Version=""$apiVersion"" />"
$csproj | Set-Content .\samples\AzureFunction40\AzureFunction40.csproj

#update csproj with new apiVersion
$csproj = Get-Content .\samples\NetFrameworkFormUpload\NetFrameworkFormUpload\NetFrameworkFormUpload.csproj
$csproj = $csproj -replace "<PackageReference Include=""Agravity.Public"" Version="".*"" />", "<PackageReference Include=""Agravity.Public"" Version=""$apiVersion"" />"
$csproj | Set-Content .\samples\NetFrameworkFormUpload\NetFrameworkFormUpload\NetFrameworkFormUpload.csproj

