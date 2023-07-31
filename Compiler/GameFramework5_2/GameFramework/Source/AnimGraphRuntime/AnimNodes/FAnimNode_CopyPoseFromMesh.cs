#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Simple controller to copy a bone&#39;s transform to another one.</summary>
[CppInclude("AnimNodes/AnimNode_CopyPoseFromMesh.h")]
public partial struct FAnimNode_CopyPoseFromMesh {
	public TWeakObjectPtr<USkeletalMeshComponent> SourceMeshComponent;
	public bool bUseAttachedParent;
	public bool bCopyCurves;
	public bool bCopyCustomAttributes;
	public bool bUseMeshPose;
	public string RootBoneToCopy;
}
