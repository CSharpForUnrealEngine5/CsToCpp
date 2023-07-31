#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>* Retrieves the closest U value from a given Spline and a position</summary>
[CppInclude("ControlRigSplineUnits.h")]
public partial struct FRigUnit_ClosestParameterFromControlRigSpline {
	public FControlRigSpline Spline;
	public FVector Position;
	public float U;
}
