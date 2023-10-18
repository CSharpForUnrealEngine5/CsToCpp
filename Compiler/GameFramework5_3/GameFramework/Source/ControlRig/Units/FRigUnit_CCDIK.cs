namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>The CCID solver can solve N-Bone chains using</summary>
[CppInclude("Units/Highlevel/Hierarchy/RigUnit_CCDIK.h")]
public partial struct FRigUnit_CCDIK {
	public FName StartBone;
	public FName EffectorBone;
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
