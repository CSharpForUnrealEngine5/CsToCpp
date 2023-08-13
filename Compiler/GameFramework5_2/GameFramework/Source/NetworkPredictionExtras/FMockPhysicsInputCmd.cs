namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Making this a blueprint type to that it can be filled out by BPs.</summary>
[CppInclude("MockPhysicsSimulation.h")]
public partial struct FMockPhysicsInputCmd {
	public FVector MovementInput;
	public bool bJumpedPressed;
	public bool bChargePressed;
}
