namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Movement capabilities, determining available movement options for Pawns and used by AI for reachability tests.</summary>
[CppInclude("AI/Navigation/NavigationTypes.h")]
public partial struct FMovementProperties {
	public bool bCanCrouch;
	public bool bCanJump;
	public bool bCanWalk;
	public bool bCanSwim;
	public bool bCanFly;
}
