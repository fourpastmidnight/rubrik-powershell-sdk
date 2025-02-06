<#
.SYNOPSIS
    Run the Rubrik PowerShell SDK tests.

.DESCRIPTION
    This script runs the unit and e2e tests for both
    the Core and Toolkit components of the RSC SDK.

    By default, all tests are run. You can skip some tests
    by passing the appropriate switches.

    The script will stop on the first error.

.PARAMETER SkipUnitTests
    Skip all unit tests (in Core and Toolkit).

.PARAMETER SkipE2ETests
    Skip all e2e tests (in Core and Toolkit).

.PARAMETER SkipCoreTests
    Skip all Core tests (unit and e2e).

.PARAMETER SkipToolkitTests
    Skip all Toolkit tests (unit and e2e).

.EXAMPLE
    .\Utils\Test-RscSdk.ps1 -SkipUnitTests
    # Run only e2e tests for Core and Toolkit.

.EXAMPLE
    .\Utils\Test-RscSdk.ps1 -SkipCoreTests
    # Run only Toolkit tests.
    # Note: this is what ToolkitDev.ps1's Test-RscToolkit does.

.EXAMPLE
    .\Utils\Test-RscSdk.ps1 -SkipE2ETests -SkipCoreTests
    # Run only Toolkit unit tests.
#>
[CmdletBinding()] # Enable common parameters like -Verbose
param(
    [switch]$SkipUnitTests = $false,
    [switch]$SkipE2ETests = $false,
    [switch]$SkipCoreTests = $false,
    [switch]$SkipToolkitTests = $false,
    [switch]$CI = $false
)
# Change to the root of the repository
Set-Location $PSScriptRoot\..

# Stop on error
$ErrorActionPreference = "Stop"

# Uncomment this to enable Write-Debug output
# $DebugPreference = "Continue"

# With -CI we need to have the service account file
# passed in as an environment variable
if ($CI) {
    if ($env:RSC_SERVICE_ACCOUNT_FILE) {
        $serviceAccountFile = $env:RSC_SERVICE_ACCOUNT_FILE
        # bail out if the file doesn't exist
        if (-not (Test-Path $serviceAccountFile)) {
            throw "SA Unavailable (File not found: $serviceAccountFile)."
        }
        # bail out if the file is empty
        if ((Get-Content $serviceAccountFile) -eq "") {
            throw "SA Unavailable (File is empty: $serviceAccountFile)."
        }
        Set-Location $PSScriptRoot\..
        .\Utils\Import-RscModuleFromLocalOutputDir.ps1
        Set-RscServiceAccountFile -InputFilePath $serviceAccountFile -DisablePrompts -KeepOriginalClearTextFile
    }
    else {
        throw "SA Unavailable (Environment variable RSC_SERVICE_ACCOUNT_FILE not set)."
    }
}

# Run tests
if ( -not $SkipUnitTests ) {
    if ( -not $SkipCoreTests ) {
        # Run Core unit tests (Pester)
        Set-Location $PSScriptRoot\..
        $results = .\Toolkit\Utils\Run-PesterTests.ps1 .\Tests\unit
        if ($results.Failed.Count -gt 0) {
            Write-Error "Pester Core unit tests failed."
            exit 1
        }
        else {
            Write-Output "Pester Core unit tests passed."
        }

        # Run Core unit tests (C#)
        Set-Location $PSScriptRoot\..\RubrikSecurityCloud\RubrikSecurityCloud.Common.Tests\
        dotnet test
        if ($LASTEXITCODE -ne 0) {
            Write-Error "C# unit tests failed."
            exit $LASTEXITCODE
        }
        else {
            Write-Output "C# unit tests passed."
        }

        Set-Location $PSScriptRoot\..
    }

    if ( -not $SkipToolkitTests ) {
        # Run Toolkit unit tests (Pester)
        Set-Location $PSScriptRoot\..
        $results = .\Toolkit\Utils\Run-PesterTests.ps1 .\Toolkit\Tests\unit
        if ($results.Failed.Count -gt 0) {
            Write-Error "Pester Toolkit unit tests failed."
            exit 1
        }
        else {
            Write-Output "Pester Toolkit unit tests passed."
        }
    }
}

if ( -not $SkipE2ETests ) {
    if ( -not $SkipCoreTests ) {
        # Run Core e2e tests (Pester)
        Set-Location $PSScriptRoot\..
        $results = .\Toolkit\Utils\Run-PesterTests.ps1 .\Tests\e2e
        if ($results.Failed.Count -gt 0) {
            Write-Error "Pester Core e2e tests failed."
            exit 1
        }
        else {
            Write-Output "Pester Core e2e tests passed."
        }
    }

    if ( -not $SkipToolkitTests ) {
        # Run Toolkit e2e tests (Pester)
        Set-Location $PSScriptRoot\..
        $results = .\Toolkit\Utils\Run-PesterTests.ps1 .\Toolkit\Tests\e2e
        if ($results.Failed.Count -gt 0) {
            Write-Error "Pester Toolkit e2e tests failed."
            exit 1
        }
        else {
            Write-Output "Pester Toolkit e2e tests passed."
        }
    }
}
