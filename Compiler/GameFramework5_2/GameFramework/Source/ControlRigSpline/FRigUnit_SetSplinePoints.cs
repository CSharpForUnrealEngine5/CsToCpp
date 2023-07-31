#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>* Set the points of a spline, given a spline and an array of positions</summary>
[CppInclude("ControlRigSplineUnits.h")]
public partial struct FRigUnit_SetSplinePoints {
	public TArray<FVector> Points;
	public FControlRigSpline Spline;
}
