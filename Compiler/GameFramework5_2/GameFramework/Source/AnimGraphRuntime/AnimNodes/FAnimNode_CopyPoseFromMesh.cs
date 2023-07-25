#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AnimNodes/AnimNode_CopyPoseFromMesh.h")]
///<summary>Simple controller to copy a bone's transform to another one.</summary>
public partial struct FAnimNode_CopyPoseFromMesh {
// AnimNode_CopyPoseFromMesh
	public TWeakObjectPtr<USkeletalMeshComponent> SourceMeshComponent;
	public bool bUseAttachedParent;
	public bool bCopyCurves;
	public bool bCopyCustomAttributes;
	public bool bUseMeshPose;
	public string RootBoneToCopy;
}
