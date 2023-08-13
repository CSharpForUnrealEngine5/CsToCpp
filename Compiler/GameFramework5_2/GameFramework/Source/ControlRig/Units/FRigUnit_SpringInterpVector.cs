namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Uses a simple spring model to interpolate a vector from Current to Target.</summary>
[CppInclude("Units/Simulation/RigUnit_SpringInterp.h")]
public partial struct FRigUnit_SpringInterpVector {
	public FVector Current;
	public FVector Target;
	public float Stiffness;
	public float CriticalDamping;
	public float Mass;
	public FVector Result;
	public FVectorSpringState SpringState;
}
