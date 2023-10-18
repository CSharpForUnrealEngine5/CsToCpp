namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>* Retrieves the tangent from a given Spline and U value</summary>
[CppInclude("ControlRigSplineUnits.h")]
public partial struct FRigUnit_TangentFromControlRigSpline {
	public FControlRigSpline Spline;
	public float U;
	public FVector Tangent;
}
