#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("EditorTutorialSettings.h")]
///<summary>Editor-wide tutorial settings</summary>
public partial class UEditorTutorialSettings : UObject {
// EditorTutorialSettings
	public bool bDisableAllTutorialAlerts;
	public TArray<FTutorialCategory> Categories;
	public FSoftClassPath StartupTutorial;
	public TArray<FTutorialContext> TutorialContexts;
}
