#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Units/Highlevel/Hierarchy/RigUnit_CCDIK.h")]
///<summary>The CCID solver can solve N-Bone chains using</summary>
public partial struct FRigUnit_CCDIK {
// RigUnit_CCDIK
	public string StartBone;
	public string EffectorBone;
	public FTransform EffectorTransform;
	public float Precision;
	public float Weight;
	public int MaxIterations;
	public bool bStartFromTail;
	public float BaseRotationLimit;
	public TArray<FRigUnit_CCDIK_RotationLimit> RotationLimits;
	public bool bPropagateToChildren;
	public FRigUnit_CCDIK_WorkData WorkData;
}
