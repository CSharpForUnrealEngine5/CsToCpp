#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Navigation/PathFollowingComponent.h")]
///<summary>DEPRECATED, will be removed with GetPathActionType function</summary>
public enum EPathFollowingAction {
	Error=0,
	NoMove=1,
	DirectMove=2,
	PartialPath=3,
	PathToGoal=4,
}
