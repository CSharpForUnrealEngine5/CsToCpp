#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AnimNodes/AnimNode_RetargetPoseFromMesh.h")]
public partial struct FAnimNode_RetargetPoseFromMesh {
	public TWeakObjectPtr<USkeletalMeshComponent> SourceMeshComponent;
	public bool bUseAttachedParent;
	public UIKRetargeter IKRetargeterAsset;
	public FRetargetProfile CustomRetargetProfile;
	public bool bSuppressWarnings;
	public bool bCopyCurves;
	public UIKRetargetProcessor Processor;
}
