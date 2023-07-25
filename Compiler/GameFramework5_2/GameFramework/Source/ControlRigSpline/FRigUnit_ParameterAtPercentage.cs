#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ControlRigSplineUnits.h")]
///<summary>* Returns the U parameter of a spline given a length percentage (0.0 - 1.0)</summary>
public partial struct FRigUnit_ParameterAtPercentage {
// RigUnit_ParameterAtPercentage
	public FControlRigSpline Spline;
	public float Percentage;
	public float U;
}
