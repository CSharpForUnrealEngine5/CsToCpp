#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Uses a simple spring model to interpolate a float from Current to Target.</summary>
[CppInclude("Units/Simulation/RigUnit_SpringInterp.h")]
public partial struct FRigUnit_SpringInterp {
	public float Current;
	public float Target;
	public float Stiffness;
	public float CriticalDamping;
	public float Mass;
	public float Result;
	public FFloatSpringState SpringState;
}
