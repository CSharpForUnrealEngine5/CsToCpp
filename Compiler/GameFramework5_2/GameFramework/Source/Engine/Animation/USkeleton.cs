#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Animation/Skeleton.h")]
///<summary>USkeleton : that links between mesh and animation</summary>
public partial class USkeleton : UObject {
// Skeleton
	public TArray<FBoneNode> BoneTree;
	public TArray<FTransform> RefLocalPoses_DEPRECATED;
	public FGuid VirtualBoneGuid;
	public TArray<FVirtualBone> VirtualBones;
	public TArray<TSoftObjectPtr<USkeleton>> CompatibleSkeletons;
	public TArray<USkeletalMeshSocket> Sockets;
	public FSmartNameContainer SmartNames;
	public TArray<UBlendProfile> BlendProfiles;
	public UObject GetBlendProfile(string InProfileName) { return default; }
	public TArray<FAnimSlotGroup> SlotGroups;
	public TSoftObjectPtr<USkeletalMesh> PreviewSkeletalMesh;
	public TSoftObjectPtr<UDataAsset> AdditionalPreviewSkeletalMeshes;
	public FRigConfiguration RigConfig;
	public TArray<string> AnimationNotifies;
	public FPreviewAssetAttachContainer PreviewAttachedAssetContainer;
	public void AddCompatibleSkeleton(UObject SourceSkeleton) {}
	public TArray<UAssetUserData> AssetUserData;
}
