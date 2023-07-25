#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("TutorialSettings.h")]
///<summary>Per-project tutorial settings</summary>
public partial class UTutorialSettings : UObject {
// TutorialSettings
	public TArray<FTutorialCategory> Categories;
	public FSoftClassPath StartupTutorial;
}
