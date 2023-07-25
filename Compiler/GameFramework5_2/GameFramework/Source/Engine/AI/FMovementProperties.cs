#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AI/Navigation/NavigationTypes.h")]
///<summary>Movement capabilities, determining available movement options for Pawns and used by AI for reachability tests.</summary>
public partial struct FMovementProperties {
// MovementProperties
	public bool bCanCrouch;
	public bool bCanJump;
	public bool bCanWalk;
	public bool bCanSwim;
	public bool bCanFly;
}
