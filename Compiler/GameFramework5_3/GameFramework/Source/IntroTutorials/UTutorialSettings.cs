namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Per-project tutorial settings</summary>
[CppInclude("TutorialSettings.h")]
public partial class UTutorialSettings : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Categories for tutorials</summary>
	public TArray<FTutorialCategory> Categories;
	///<summary>Tutorial to start on project startup</summary>
	public FSoftClassPath StartupTutorial;
}
