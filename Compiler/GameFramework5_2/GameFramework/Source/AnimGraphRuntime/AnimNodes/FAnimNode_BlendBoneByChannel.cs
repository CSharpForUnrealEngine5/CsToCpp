#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AnimNodes/AnimNode_BlendBoneByChannel.h")]
public partial struct FAnimNode_BlendBoneByChannel {
// AnimNode_BlendBoneByChannel
	public FPoseLink A;
	public FPoseLink B;
	public TArray<FBlendBoneByChannelEntry> BoneDefinitions;
	public float Alpha;
	public FInputScaleBias AlphaScaleBias;
	public EBoneControlSpace TransformsSpace;
}
