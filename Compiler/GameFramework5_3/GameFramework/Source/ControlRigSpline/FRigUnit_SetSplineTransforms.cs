namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>* Set the points of a spline, given a spline and an array of positions</summary>
[CppInclude("ControlRigSplineUnits.h")]
public partial struct FRigUnit_SetSplineTransforms {
	public TArray<FTransform> Transforms;
	public FControlRigSpline Spline;
}
