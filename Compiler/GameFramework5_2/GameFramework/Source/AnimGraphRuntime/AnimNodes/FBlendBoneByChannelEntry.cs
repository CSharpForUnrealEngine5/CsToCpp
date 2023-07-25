#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AnimNodes/AnimNode_BlendBoneByChannel.h")]
public partial struct FBlendBoneByChannelEntry {
// BlendBoneByChannelEntry
	public FBoneReference SourceBone;
	public FBoneReference TargetBone;
	public bool bBlendTranslation;
	public bool bBlendRotation;
	public bool bBlendScale;
}
