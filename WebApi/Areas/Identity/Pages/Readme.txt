Razor Page overrides exist here.

To install code generator, run: 
	dotnet tool install -g dotnet-aspnet-codegenerator

To generate files:
 1. Go to ~\WebApi\ in command line
 2. To see a list of files that can be overridden, run:
	dotnet aspnet-codegenerator identity -lf
 3. Specify file in -fi option (separate multiple files with a semicolon) and run:
	dotnet aspnet-codegenerator identity -dc GrindstoneDataContext -u GrindstoneUser -fi "Account.ResetPassword"
 4. Delete unwanted generated files:
	GrindstoneDataContext.cs
	GrindstoneUser.cs
	IdentityHostingStartup.cs
	_ValidatiationScriptsPartial.cshtml
	ScaffoldingReadMe.txt
	_LoginPartial.cshtml
 5. Revert unwanted generated changes:
	appsettings.json
 6. Fix data context and user namespaces in .cshtml.cs files.