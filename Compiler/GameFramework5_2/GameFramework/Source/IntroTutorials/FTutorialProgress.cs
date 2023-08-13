namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Track the progress of an individual tutorial</summary>
[CppInclude("TutorialStateSettings.h")]
public partial struct FTutorialProgress {
	public FSoftClassPath Tutorial;
	public int CurrentStage;
	public bool bUserDismissed;
}
