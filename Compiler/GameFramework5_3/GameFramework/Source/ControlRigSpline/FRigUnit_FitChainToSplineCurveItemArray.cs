namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Fits a given chain to a spline curve.</summary>
[CppInclude("ControlRigSplineUnits.h")]
public partial struct FRigUnit_FitChainToSplineCurveItemArray {
	public TArray<FRigElementKey> Items;
	public FControlRigSpline Spline;
	public EControlRigCurveAlignment Alignment;
	public float Minimum;
	public float Maximum;
	public int SamplingPrecision;
	public FVector PrimaryAxis;
	public FVector SecondaryAxis;
	public FVector PoleVectorPosition;
	public TArray<FRigUnit_FitChainToCurve_Rotation> Rotations;
	public ERigVMAnimEasingType RotationEaseType;
	public float Weight;
	public bool bPropagateToChildren;
	public FRigUnit_FitChainToCurve_DebugSettings DebugSettings;
	public FRigUnit_FitChainToCurve_WorkData WorkData;
}
