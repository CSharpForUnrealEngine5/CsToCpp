namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Controller which implements the CCDIK IK approximation algorithm</summary>
[CppInclude("BoneControllers/AnimNode_CCDIK.h")]
public partial struct FAnimNode_CCDIK {
	public FVector EffectorLocation;
	public EBoneControlSpace EffectorLocationSpace;
	public FBoneSocketTarget EffectorTarget;
	public FBoneReference TipBone;
	public FBoneReference RootBone;
	public float Precision;
	public int MaxIterations;
	public bool bStartFromTail;
	public bool bEnableRotationLimit;
	public TArray<float> RotationLimitPerJoints;
}
