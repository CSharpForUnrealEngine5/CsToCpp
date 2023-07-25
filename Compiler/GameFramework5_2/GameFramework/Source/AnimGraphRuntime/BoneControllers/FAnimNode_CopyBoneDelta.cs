#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("BoneControllers/AnimNode_CopyBoneDelta.h")]
///<summary>Simple controller to copy a transform relative to the ref pose to the target bone,</summary>
public partial struct FAnimNode_CopyBoneDelta {
// AnimNode_CopyBoneDelta
	public FBoneReference SourceBone;
	public FBoneReference TargetBone;
	public bool bCopyTranslation;
	public bool bCopyRotation;
	public bool bCopyScale;
	public CopyBoneDeltaMode CopyMode;
	public float TranslationMultiplier;
	public float RotationMultiplier;
	public float ScaleMultiplier;
}
