#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("UpdateManager.h")]
///<summary>Various states the update manager flows through as it checks for patches/hotfixes</summary>
public enum EUpdateState {
	UpdateIdle=0,
	UpdatePending=1,
	CheckingForPatch=2,
	DetectingPlatformEnvironment=3,
	CheckingForHotfix=4,
	WaitingOnInitialLoad=5,
	InitialLoadComplete=6,
	UpdateComplete=7,
}
