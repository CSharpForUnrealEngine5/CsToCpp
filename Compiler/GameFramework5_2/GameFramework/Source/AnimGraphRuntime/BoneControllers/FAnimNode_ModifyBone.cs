#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("BoneControllers/AnimNode_ModifyBone.h")]
///<summary>Simple controller that replaces or adds to the translation/rotation of a single bone.</summary>
public partial struct FAnimNode_ModifyBone {
// AnimNode_ModifyBone
	public FBoneReference BoneToModify;
	public FVector Translation;
	public FRotator Rotation;
	public FVector Scale;
	public EBoneModificationMode TranslationMode;
	public EBoneModificationMode RotationMode;
	public EBoneModificationMode ScaleMode;
	public EBoneControlSpace TranslationSpace;
	public EBoneControlSpace RotationSpace;
	public EBoneControlSpace ScaleSpace;
}
