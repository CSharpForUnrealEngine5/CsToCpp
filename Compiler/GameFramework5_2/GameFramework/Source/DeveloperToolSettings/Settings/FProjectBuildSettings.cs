namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Settings/ProjectPackagingSettings.h")]
public partial struct FProjectBuildSettings {
	public string Name;
	public string HelpText;
	public TArray<string> SpecificPlatforms;
	public string BuildCookRunParams;
}
