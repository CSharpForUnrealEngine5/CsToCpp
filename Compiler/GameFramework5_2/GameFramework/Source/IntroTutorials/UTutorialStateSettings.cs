#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("TutorialStateSettings.h")]
///<summary>Tutorial settings used to track completion state</summary>
public partial class UTutorialStateSettings : UObject {
// TutorialStateSettings
	public TArray<FTutorialProgress> TutorialsProgress;
	public bool bDismissedAllTutorials;
}
