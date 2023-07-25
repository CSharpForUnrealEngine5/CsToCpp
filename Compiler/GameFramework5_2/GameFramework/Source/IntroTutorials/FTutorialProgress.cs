#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("TutorialStateSettings.h")]
///<summary>Track the progress of an individual tutorial</summary>
public partial struct FTutorialProgress {
// TutorialProgress
	public FSoftClassPath Tutorial;
	public int CurrentStage;
	public bool bUserDismissed;
}
