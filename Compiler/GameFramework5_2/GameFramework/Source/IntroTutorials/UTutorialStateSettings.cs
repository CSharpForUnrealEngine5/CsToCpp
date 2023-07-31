#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Tutorial settings used to track completion state</summary>
[CppInclude("TutorialStateSettings.h")]
public partial class UTutorialStateSettings : UObject {
	///<summary>TutorialsProgress</summary>
	public TArray<FTutorialProgress> TutorialsProgress;
	///<summary>Record if user has chosen to cancel all tutorials</summary>
	public bool bDismissedAllTutorials;
}
