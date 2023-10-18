namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Scale the length of a chain of bones.</summary>
[CppInclude("BoneControllers/AnimNode_ScaleChainLength.h")]
public partial struct FAnimNode_ScaleChainLength {
	public FPoseLink InputPose;
	public float DefaultChainLength;
	public FBoneReference ChainStartBone;
	public FBoneReference ChainEndBone;
	public FVector TargetLocation;
	public float Alpha;
	public FInputScaleBias AlphaScaleBias;
	public EScaleChainInitialLength ChainInitialLength;
}
