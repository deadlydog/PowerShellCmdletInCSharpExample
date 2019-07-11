# PowerShell cmdlet in C# example

This repo is here simply to show off how you can create a simple PowerShell Core (cross platform) cmdlet in C# and unit test it with xUnit.

We use the `PowerShellStandard.Library` NuGet package to get a .Net Standard 2.0 (cross platform) version of the `System.Management.Automation` assembly, which contains all of the PowerShell types and functionality we require to build a cmdlet.

## Tests

Unfortunately the .Net Core version of the `System.Management.Automation` assembly currently [does not work the same way as the .Net Framework version](https://stackoverflow.com/questions/56696574/how-to-unit-test-a-powershell-core-binary-cmdlet-in-c-sharp) and throws an exception when trying to do unit tests with it, so to work around this the `PowerShellCmdletInCSharpExample.Tests` project is a .Net Framework project and references the .Net Framework version of the `System.Management.Automation.dll`.
