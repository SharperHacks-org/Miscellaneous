<#
    Copy ConfigExperiments.appsetting.json content to testhost.appsetting.json file.
#>
param(
    [Parameter(Mandatory=$true)] [string] $sourceFile,
    [Parameter(Mandatory=$true)] [string] $destFile
)

Write-Output "Copying $sourceFile to $destFile, with modifications."
$content = [System.IO.File]::ReadAllText($sourceFile).Replace("ConfigExperiments","testhost")
[System.IO.File]::WriteAllText($destFile, $content)
