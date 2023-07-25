#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Units/Highlevel/Hierarchy/RigUnit_FitChainToCurve.h")]
///<summary>Fits a given chain to a four point bezier curve.</summary>
public partial struct FRigUnit_FitChainToCurveItemArray {
// RigUnit_FitChainToCurveItemArray
	public TArray<FRigElementKey> Items;
	public FRigVMFourPointBezier Bezier;
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
