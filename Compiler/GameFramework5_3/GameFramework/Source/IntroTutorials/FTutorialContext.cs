namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Named context that corresponds to a particular tutorial</summary>
[CppInclude("EditorTutorialSettings.h")]
public partial struct FTutorialContext {
	public FName Context;
	public string BrowserFilter;
	public FSoftClassPath AttractTutorial;
	public FSoftClassPath LaunchTutorial;
}
