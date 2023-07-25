#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("FBIKShared.h")]
public partial struct FSolverInput {
// SolverInput
	public float LinearMotionStrength;
	public float MinLinearMotionStrength;
	public float AngularMotionStrength;
	public float MinAngularMotionStrength;
	public float DefaultTargetClamp;
	public float Precision;
	public float Damping;
	public int MaxIterations;
	public bool bUseJacobianTranspose;
}
