#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MockPhysicsSimulation.h")]
///<summary>Making this a blueprint type to that it can be filled out by BPs.</summary>
public partial struct FMockPhysicsInputCmd {
// MockPhysicsInputCmd
	public FVector MovementInput;
	public bool bJumpedPressed;
	public bool bChargePressed;
}
