#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Animation/AnimBlueprint.h")]
///<summary>An Anim Blueprint is essentially a specialized Blueprint whose graphs control the animation of a Skeletal Mesh.</summary>
public partial class UAnimBlueprint : UBlueprint {
// AnimBlueprint
	public USkeleton TargetSkeleton;
	public TArray<FAnimGroupInfo> Groups;
	public bool bIsTemplate;
	public bool bUseMultiThreadedAnimationUpdate;
	public bool bWarnAboutBlueprintUsage;
	public bool bEnableLinkedAnimLayerInstanceSharing;
	public TArray<FAnimParentNodeAssetOverride> ParentAssetOverrides;
	public TArray<UPoseWatchFolder> PoseWatchFolders;
	public TArray<UPoseWatch> PoseWatches;
	public TSoftObjectPtr<USkeletalMesh> PreviewSkeletalMesh;
	public TSoftObjectPtr<UAnimBlueprint> PreviewAnimationBlueprint;
	public EPreviewAnimationBlueprintApplicationMethod PreviewAnimationBlueprintApplicationMethod;
	public string PreviewAnimationBlueprintTag;
}
