#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("BoneControllers/AnimNode_CCDIK.h")]
///<summary>Controller which implements the CCDIK IK approximation algorithm</summary>
public partial struct FAnimNode_CCDIK {
// AnimNode_CCDIK
	public FVector EffectorLocation;
	public byte EffectorLocationSpace;
	public FBoneSocketTarget EffectorTarget;
	public FBoneReference TipBone;
	public FBoneReference RootBone;
	public float Precision;
	public int MaxIterations;
	public bool bStartFromTail;
	public bool bEnableRotationLimit;
	public TArray<float> RotationLimitPerJoints;
}
