namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Editor-wide tutorial settings</summary>
[CppInclude("EditorTutorialSettings.h")]
public partial class UEditorTutorialSettings : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Disable the pulsing alert that indicates a new tutorial is available.</summary>
	public bool bDisableAllTutorialAlerts;
	///<summary>Categories for tutorials</summary>
	public TArray<FTutorialCategory> Categories;
	///<summary>Tutorial to start on Editor startup</summary>
	public FSoftClassPath StartupTutorial;
	///<summary>Tutorials used in various contexts - e.g. the various asset editors</summary>
	public TArray<FTutorialContext> TutorialContexts;
}
