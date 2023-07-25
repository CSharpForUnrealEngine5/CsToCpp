#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Units/Simulation/RigUnit_SpringInterp.h")]
///<summary>Uses a simple spring model to interpolate a float from Current to Target.</summary>
public partial struct FRigUnit_SpringInterp {
// RigUnit_SpringInterp
	public float Current;
	public float Target;
	public float Stiffness;
	public float CriticalDamping;
	public float Mass;
	public float Result;
	public FFloatSpringState SpringState;
}
