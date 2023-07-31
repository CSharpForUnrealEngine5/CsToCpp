#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Simple controller to copy a transform relative to the ref pose to the target bone,</summary>
[CppInclude("BoneControllers/AnimNode_CopyBoneDelta.h")]
public partial struct FAnimNode_CopyBoneDelta {
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
