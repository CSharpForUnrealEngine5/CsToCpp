namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Navigation/PathFollowingComponent.h")]
[CppEnumInNamespace]
public enum EPathFollowingStatus {
	Idle=0,
	Waiting=1,
	Paused=2,
	Moving=3,
}
