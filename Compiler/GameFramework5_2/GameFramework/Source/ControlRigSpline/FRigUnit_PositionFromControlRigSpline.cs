namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>* Retrieves the position from a given Spline and U value</summary>
[CppInclude("ControlRigSplineUnits.h")]
public partial struct FRigUnit_PositionFromControlRigSpline {
	public FControlRigSpline Spline;
	public float U;
	public FVector Position;
}
