#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("EditorTutorialSettings.h")]
///<summary>Named context that corresponds to a particular tutorial</summary>
public partial struct FTutorialContext {
// TutorialContext
	public string Context;
	public string BrowserFilter;
	public FSoftClassPath AttractTutorial;
	public FSoftClassPath LaunchTutorial;
}
