namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/EngineTypes.h")]
///<summary>Movement modes for Characters.</summary>
public enum EMovementMode {
	MOVE_None=0,
	MOVE_Walking=1,
	MOVE_NavWalking=2,
	MOVE_Falling=3,
	MOVE_Swimming=4,
	MOVE_Flying=5,
	MOVE_Custom=6,
	MOVE_MAX=7,
}
