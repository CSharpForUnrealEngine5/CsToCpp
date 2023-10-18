namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>* Returns the U parameter of a spline given a length percentage (0.0 - 1.0)</summary>
[CppInclude("ControlRigSplineUnits.h")]
public partial struct FRigUnit_ParameterAtPercentage {
	public FControlRigSpline Spline;
	public float Percentage;
	public float U;
}
