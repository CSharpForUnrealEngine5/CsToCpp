namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Fits a given chain to a spline curve.</summary>
[CppInclude("ControlRigSplineUnits.h")]
public partial struct FRigUnit_SplineConstraint {
	public TArray<FRigElementKey> Items;
	public FControlRigSpline Spline;
	public EControlRigCurveAlignment Alignment;
	public float Minimum;
	public float Maximum;
	public FVector PrimaryAxis;
	public FVector SecondaryAxis;
	public bool bPropagateToChildren;
	public FRigUnit_SplineConstraint_WorkData WorkData;
}
