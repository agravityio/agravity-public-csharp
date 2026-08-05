# This script regenerates the SDK into the repository root.
# The OpenAPI Generator rewrites both ./src and ./docs as generated output.
# Do not place hand-written documentation under ./docs because it can be overwritten on the next generation run.
# Keep manual repository documentation in a stable non-generated location such as the repository root.

# check if $env:API_KEY is set, if not: exit
if ($null -eq $env:AGRAVITY_OPEN_API_KEY) {
    Write-Host "Please set AGRAVITY_OPEN_API_KEY environment variable"
    # wait for user input
    Write-Host "Press any key to continue ..."
    $null = $Host.UI.RawUI.ReadKey("NoEcho,IncludeKeyDown")
    exit
}

# check if $env:API_KEY is set, if not: exit
if ($null -eq $env:OPENAPI_GENERATOR) {
    Write-Host "Please set OPENAPI_GENERATOR path to the openapi-generator-cli.jar"
    # wait for user input
    Write-Host "Press any key to continue ..."
    $null = $Host.UI.RawUI.ReadKey("NoEcho,IncludeKeyDown")
    exit
}


# check REST API endpoint /version if backend is running, catch it and if it is not running: exit
$version = (Invoke-RestMethod -Uri http://localhost:7072/api/version  -Headers @{"x-functions-key" = $env:AGRAVITY_OPEN_API_KEY} -Method Get -ContentType "application/json" -ErrorAction SilentlyContinue)
if ($null -eq $version) {
    Write-Host "Please start backend before generating API"
    # wait for user input
    Write-Host "Press any key to continue ..."
    $null = $Host.UI.RawUI.ReadKey("NoEcho,IncludeKeyDown")
    exit
}

$apiVersion = $version.version

# check if apiVersion is valid
if ($null -eq $apiVersion) {
    Write-Host "Please provide apiVersion as parameter"
    # wait for user input
    Write-Host "Press any key to continue ..."
    $null = $Host.UI.RawUI.ReadKey("NoEcho,IncludeKeyDown")
    exit
}
# echo apiVersion
Write-Host "Generate API with apiVersion: $apiVersion"

# wait for user input
Write-Host "Press any key to continue ..."
$null = $Host.UI.RawUI.ReadKey("NoEcho,IncludeKeyDown")

Write-Host "Delete all generated folders (.\src, .\docs) and files (.\openapi.json, .\out\Agravity.Public.$apiVersion.nupkg) without error output"

# delete folder .\src without error output
Remove-Item -Path .\src -Recurse -Force -ErrorAction SilentlyContinue
Remove-Item -Path .\docs -Recurse -Force -ErrorAction SilentlyContinue
Remove-Item -Path .\openapi.json -Force -ErrorAction SilentlyContinue
Remove-Item -Path ".\out\Agravity.Public.$apiVersion.nupkg" -Force -ErrorAction SilentlyContinue

Write-Host "Calling public API"

# download file with Authentication header (Bearer token)
Invoke-WebRequest -Uri "http://localhost:7072/api/openapi/v3.json" -Headers @{"x-functions-key" = $env:AGRAVITY_OPEN_API_KEY} -OutFile "openapi.json"

# check if openapi.json exists and is not empty; if not: exit
if (!(Test-Path "openapi.json") -or (Get-Content "openapi.json" -Raw) -eq "") {
    Write-Host "openapi.json is empty or does not exist"
    $null = $Host.UI.RawUI.ReadKey("NoEcho,IncludeKeyDown")
    exit
}

# update @openapitools/openapi-generator-cli version
#npm install @openapitools/openapi-generator-cli -g

# generate API
# The generator writes repository-level artifacts, including the generated ./docs folder.
# Treat everything under ./docs as generated content.
$params="packageName=Agravity.Public,library=restsharp,targetFramework=net8.0;net9.0;net10.0;netstandard2.0,packageVersion="+$apiVersion
# Write-Host("Executing: openapi-generator generate -i https://api.agravity.com/v2/swagger.json -g csharp-netcore -o src -p "+$params);
#npx @openapitools/openapi-generator-cli generate -i openapi.json -g csharp-netcore -o . --additional-properties=$params
java -jar $env:OPENAPI_GENERATOR generate -i openapi.json -g csharp -o . --additional-properties=$params

# delete openapi.json
Remove-Item -Path .\openapi.json -Force

#change directory to src
Set-Location .\src
# replace all "Dictionary>" with "Dictionary<string, object>>"
Get-ChildItem -Recurse -File | ForEach-Object { (Get-Content $_.FullName) -replace "Dictionary>", "Dictionary<string, object>>" | Set-Content $_.FullName }

Start-Sleep -s 2

# replace all "Dictionary<string, Object>" with "Dictionary<string, object>"
Get-ChildItem -Recurse -File | ForEach-Object { (Get-Content $_.FullName) -replace "Dictionary<string, Object>", "Dictionary<string, object>" | Set-Content $_.FullName }

Start-Sleep -s 2

#replace all "Dictionary&gt;" with "Dictionary&lt;string, object&gt;&gt;"
Get-ChildItem -Recurse -File | ForEach-Object { (Get-Content $_.FullName) -replace "Dictionary&gt;", "Dictionary&lt;string, object&gt;&gt;" | Set-Content $_.FullName }

# go one directory up
Set-Location ..

# git discard all neccessary files

# git discard files
git checkout -- .\.gitignore
git checkout -- .\Agravity.Public.sln
git checkout -- .\extract_thirdparty_licenses.bat
git checkout -- .\icon.png
git checkout -- .\nuget.exe
git checkout -- .\openapitools.json
git checkout -- .\src\Agravity.Public\Agravity.Public.nuspec
git checkout -- .\src\Agravity.Public\Agravity.Public.csproj
git checkout -- .\src\Agravity.Public\THIRD-PARTY-NOTICES.TXT
git checkout -- .\src\Agravity.Public.Test\Agravity.Public.Test.csproj

#replace old version with new version in csproj file
$csproj = Get-Content .\src\Agravity.Public\Agravity.Public.csproj
$csproj = $csproj -replace "<Version>.*</Version>", "<Version>$apiVersion</Version>"
$csproj | Set-Content .\src\Agravity.Public\Agravity.Public.csproj

# copy README.md from root to src
Copy-Item .\README.md .\src\Agravity.Public\README.md

# wait 2 seconds
Start-Sleep -s 2

# echo apiVersion
Write-Host "Build and Publish with apiVersion: $apiVersion"

# build project with release
dotnet build .\src\Agravity.Public\Agravity.Public.csproj -c Release

# execute extract third party licenses
.\extract_thirdparty_licenses.bat

# build nuget package with version
#create command 
dotnet pack .\src\Agravity.Public\Agravity.Public.csproj -c Release -o .\out /p:Version=$apiVersion

# Set API Key (once)
# nuget setApiKey xyz

# prompt to publish
Write-Host ("Publish package in version {0}? (y/n)" -f $apiVersion)
$publish = Read-Host

# check if publish
if ($publish -eq "y") {
    $packagePath = ".\out\Agravity.Public.$apiVersion.nupkg"

    if (!(Test-Path $packagePath)) {
        Write-Host "Package $packagePath not found. Skipping publish."
        exit 1
    }

    # publish nuget package
    dotnet nuget push $packagePath -s https://api.nuget.org/v3/index.json

    $changelogPath = ".\changelog.md"
    $changelogAnchor = "It will be upgraded when the Agravity Backend is upgraded and will have the same version."
    $releaseDate = Get-Date -Format "yyyy-MM-dd"
    $releaseHeader = '## AgravityAPI <a name="{0}"/> [{0}](https://www.nuget.org/packages/Agravity.Public/{0}) ({1})' -f $apiVersion, $releaseDate

    if (Test-Path $changelogPath) {
        $changelog = Get-Content $changelogPath -Raw

        if ($changelog -notmatch [regex]::Escape($releaseHeader)) {
            $releaseNotes = "$releaseHeader`r`n`r`n- Just version upgrade to match backend`r`n`r`n"

            if ($changelog.Contains($changelogAnchor)) {
                $anchorWithSpacing = "$changelogAnchor`r`n`r`n"
                $replacement = "$anchorWithSpacing$releaseNotes"

                if ($changelog.Contains($anchorWithSpacing)) {
                    $changelog = $changelog.Replace($anchorWithSpacing, $replacement)
                }
                else {
                    $replacement = "$changelogAnchor`r`n`r`n$releaseNotes"
                    $changelog = $changelog.Replace($changelogAnchor, $replacement)
                }

                Set-Content $changelogPath $changelog
            }
            else {
                Write-Host "Changelog anchor text not found. Skipping changelog update."
            }
        }
        else {
            Write-Host "Changelog entry for version $apiVersion already exists."
        }
    }
    else {
        Write-Host "changelog.md not found. Skipping changelog update."
    }

    code.cmd .\changelog.md

    Write-Host "Press any key to finish."
    $null = $Host.UI.RawUI.ReadKey("NoEcho,IncludeKeyDown")
}