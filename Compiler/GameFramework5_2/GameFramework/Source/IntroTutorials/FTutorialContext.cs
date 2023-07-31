#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Named context that corresponds to a particular tutorial</summary>
[CppInclude("EditorTutorialSettings.h")]
public partial struct FTutorialContext {
	public string Context;
	public string BrowserFilter;
	public FSoftClassPath AttractTutorial;
	public FSoftClassPath LaunchTutorial;
}
