# PowerShell cmdlet in C# example

This repo is here simply to show off how you can create a simple PowerShell Core (cross platform) cmdlet in C# and unit test it with xUnit.

We use the `PowerShellStandard.Library` NuGet package to get a .Net Standard 2.0 (cross platform) version of the `System.Management.Automation` assembly, which contains all of the PowerShell types and functionality we require to build a cmdlet.
