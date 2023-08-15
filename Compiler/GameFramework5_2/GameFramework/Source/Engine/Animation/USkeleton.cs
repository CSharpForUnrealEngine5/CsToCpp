namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>USkeleton : that links between mesh and animation</summary>
[CppInclude("Animation/Skeleton.h")]
public partial class USkeleton : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Skeleton bone tree - each contains name and parent index*</summary>
	public TArray<FBoneNode> BoneTree;
	///<summary>Reference skeleton poses in local space</summary>
	public TArray<FTransform> RefLocalPoses_DEPRECATED;
	///<summary>Guid for virtual bones.</summary>
	public FGuid VirtualBoneGuid;
	///<summary>Array of this skeletons virtual bones. These are new bones are links between two existing bones</summary>
	public TArray<FVirtualBone> VirtualBones;
	///<summary>The list of compatible skeletons.</summary>
	public TArray<TSoftObjectPtr<USkeleton>> CompatibleSkeletons;
	///<summary>Array of named socket locations, set up in editor and used as a shortcut instead of specifying</summary>
	public TArray<USkeletalMeshSocket> Sockets;
	///<summary>Container for smart name mappings</summary>
	public FSmartNameContainer SmartNames;
	///<summary>List of blend profiles available in this skeleton</summary>
	public TArray<UBlendProfile> BlendProfiles;
	///<summary>Get the specified blend profile by name</summary>
	public UBlendProfile GetBlendProfile(FName InProfileName) { return default; }
	///<summary>serialized slot groups and slot names.</summary>
	public TArray<FAnimSlotGroup> SlotGroups;
	///<summary>The default skeletal mesh to use when previewing this skeleton</summary>
	public TSoftObjectPtr<USkeletalMesh> PreviewSkeletalMesh;
	///<summary>The additional skeletal meshes to use when previewing this skeleton</summary>
	public TSoftObjectPtr<UDataAsset> AdditionalPreviewSkeletalMeshes;
	///<summary>RigConfig</summary>
	public FRigConfiguration RigConfig;
	///<summary>AnimNotifiers that has been created. Right now there is no delete step for this, but in the future we&#39;ll supply delete*</summary>
	public TArray<FName> AnimationNotifies;
	///<summary>Attached assets component for this skeleton</summary>
	public FPreviewAssetAttachContainer PreviewAttachedAssetContainer;
	///<summary>AddCompatibleSkeleton</summary>
	public void AddCompatibleSkeleton(USkeleton SourceSkeleton) {}
	///<summary>Array of user data stored with the asset</summary>
	public TArray<UAssetUserData> AssetUserData;
}
