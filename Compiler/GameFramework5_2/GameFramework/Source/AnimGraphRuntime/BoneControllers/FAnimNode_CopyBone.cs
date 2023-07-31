#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Simple controller to copy a bone&#39;s transform to another one.</summary>
[CppInclude("BoneControllers/AnimNode_CopyBone.h")]
public partial struct FAnimNode_CopyBone {
	public FBoneReference SourceBone;
	public FBoneReference TargetBone;
	public bool bCopyTranslation;
	public bool bCopyRotation;
	public bool bCopyScale;
	public EBoneControlSpace ControlSpace;
}
