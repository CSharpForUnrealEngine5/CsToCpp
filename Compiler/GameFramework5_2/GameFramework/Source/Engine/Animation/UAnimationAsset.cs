#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Animation/AnimationAsset.h")]
public partial class UAnimationAsset : UObject {
// AnimationAsset
	public USkeleton Skeleton;
	public TArray<UAnimMetaData> MetaData;
	public UAnimationAsset ParentAsset;
	public TArray<UAnimationAsset> ChildrenAssets;
	public UAssetMappingTable AssetMappingTable;
	public TArray<UAssetUserData> AssetUserData;
	public float GetPlayLength() { return default; }
	public void SetPreviewSkeletalMesh(UObject PreviewMesh) {}
	public UThumbnailInfo ThumbnailInfo;
	public UPoseAsset PreviewPoseAsset;
	public TSoftObjectPtr<USkeletalMesh> PreviewSkeletalMesh;
}
