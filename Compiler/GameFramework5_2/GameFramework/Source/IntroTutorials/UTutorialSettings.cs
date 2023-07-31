#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Per-project tutorial settings</summary>
[CppInclude("TutorialSettings.h")]
public partial class UTutorialSettings : UObject {
	///<summary>Categories for tutorials</summary>
	public TArray<FTutorialCategory> Categories;
	///<summary>Tutorial to start on project startup</summary>
	public FSoftClassPath StartupTutorial;
}
