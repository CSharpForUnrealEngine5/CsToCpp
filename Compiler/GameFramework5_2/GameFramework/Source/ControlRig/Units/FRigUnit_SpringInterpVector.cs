#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Units/Simulation/RigUnit_SpringInterp.h")]
///<summary>Uses a simple spring model to interpolate a vector from Current to Target.</summary>
public partial struct FRigUnit_SpringInterpVector {
// RigUnit_SpringInterpVector
	public FVector Current;
	public FVector Target;
	public float Stiffness;
	public float CriticalDamping;
	public float Mass;
	public FVector Result;
	public FVectorSpringState SpringState;
}
