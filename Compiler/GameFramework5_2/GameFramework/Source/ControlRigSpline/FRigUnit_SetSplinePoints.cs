namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>* Set the points of a spline, given a spline and an array of positions</summary>
[CppInclude("ControlRigSplineUnits.h")]
public partial struct FRigUnit_SetSplinePoints {
	public TArray<FVector> Points;
	public FControlRigSpline Spline;
}
