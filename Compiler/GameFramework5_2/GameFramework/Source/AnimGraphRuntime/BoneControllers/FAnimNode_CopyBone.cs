#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("BoneControllers/AnimNode_CopyBone.h")]
///<summary>Simple controller to copy a bone's transform to another one.</summary>
public partial struct FAnimNode_CopyBone {
// AnimNode_CopyBone
	public FBoneReference SourceBone;
	public FBoneReference TargetBone;
	public bool bCopyTranslation;
	public bool bCopyRotation;
	public bool bCopyScale;
	public EBoneControlSpace ControlSpace;
}
