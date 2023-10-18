namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AnimNodes/AnimNode_BlendBoneByChannel.h")]
public partial struct FBlendBoneByChannelEntry {
	public FBoneReference SourceBone;
	public FBoneReference TargetBone;
	public bool bBlendTranslation;
	public bool bBlendRotation;
	public bool bBlendScale;
}
