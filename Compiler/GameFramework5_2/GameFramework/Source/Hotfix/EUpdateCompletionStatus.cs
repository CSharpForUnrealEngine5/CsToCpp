#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("UpdateManager.h")]
///<summary>Possible outcomes at the end of an update check</summary>
public enum EUpdateCompletionStatus {
	UpdateUnknown=0,
	UpdateSuccess=1,
	UpdateSuccess_NoChange=2,
	UpdateSuccess_NeedsReload=3,
	UpdateSuccess_NeedsRelaunch=4,
	UpdateSuccess_NeedsPatch=5,
	UpdateFailure_PatchCheck=6,
	UpdateFailure_HotfixCheck=7,
	UpdateFailure_NotLoggedIn=8,
}
