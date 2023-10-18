namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AnimNodes/AnimNode_BlendBoneByChannel.h")]
public partial struct FAnimNode_BlendBoneByChannel {
	public FPoseLink A;
	public FPoseLink B;
	public TArray<FBlendBoneByChannelEntry> BoneDefinitions;
	public float Alpha;
	public FInputScaleBias AlphaScaleBias;
	public EBoneControlSpace TransformsSpace;
}
