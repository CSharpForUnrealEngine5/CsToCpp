#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>* Retrieves the tangent from a given Spline and U value</summary>
[CppInclude("ControlRigSplineUnits.h")]
public partial struct FRigUnit_TangentFromControlRigSpline {
	public FControlRigSpline Spline;
	public float U;
	public FVector Tangent;
}
