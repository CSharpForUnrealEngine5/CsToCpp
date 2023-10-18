namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Animation/AnimationAsset.h")]
public partial class UAnimationAsset : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Pointer to the Skeleton this asset can be played on .</summary>
	public USkeleton Skeleton;
	///<summary>Meta data that can be saved with the asset</summary>
	public TArray<UAnimMetaData> MetaData;
	///<summary>Parent Asset, if set, you won&#39;t be able to edit any data in here but just mapping table</summary>
	public UAnimationAsset ParentAsset;
	///<summary>note this is transient as they&#39;re added as they&#39;re loaded</summary>
	public TArray<UAnimationAsset> ChildrenAssets;
	///<summary>Asset mapping table when ParentAsset is set</summary>
	public UAssetMappingTable AssetMappingTable;
	///<summary>Array of user data stored with the asset</summary>
	public TArray<UAssetUserData> AssetUserData;
	///<summary>GetPlayLength</summary>
	public virtual float GetPlayLength() { return default; }
	///<summary>Sets or updates the preview skeletal mesh</summary>
	public void SetPreviewSkeletalMesh(USkeletalMesh PreviewMesh) {}
	///<summary>Information for thumbnail rendering</summary>
	public UThumbnailInfo ThumbnailInfo;
	///<summary>The default skeletal mesh to use when previewing this asset - this only applies when you open Persona using this asset// @todo: note that this doesn&#39;t retarget right now</summary>
	public UPoseAsset PreviewPoseAsset;
	///<summary>The default skeletal mesh to use when previewing this asset - this only applies when you open Persona using this asset</summary>
	public TSoftObjectPtr<USkeletalMesh> PreviewSkeletalMesh;
}
