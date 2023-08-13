namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Holds settings for the new project stage of the build promotion test</summary>
[CppInclude("Tests/AutomationTestSettings.h")]
public partial struct FBuildPromotionNewProjectSettings {
	public FDirectoryPath NewProjectFolderOverride;
	public string NewProjectNameOverride;
}
