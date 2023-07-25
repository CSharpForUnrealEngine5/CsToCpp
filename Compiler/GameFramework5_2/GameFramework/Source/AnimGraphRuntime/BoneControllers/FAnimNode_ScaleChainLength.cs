#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("BoneControllers/AnimNode_ScaleChainLength.h")]
///<summary>Scale the length of a chain of bones.</summary>
public partial struct FAnimNode_ScaleChainLength {
// AnimNode_ScaleChainLength
	public FPoseLink InputPose;
	public float DefaultChainLength;
	public FBoneReference ChainStartBone;
	public FBoneReference ChainEndBone;
	public FVector TargetLocation;
	public float Alpha;
	public FInputScaleBias AlphaScaleBias;
	public EScaleChainInitialLength ChainInitialLength;
}
