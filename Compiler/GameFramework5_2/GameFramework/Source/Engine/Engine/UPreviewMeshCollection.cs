#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/PreviewMeshCollection.h")]
///<summary>A simple collection of skeletal meshes used for in-editor preview</summary>
public partial class UPreviewMeshCollection : UDataAsset {
// PreviewMeshCollection
	public USkeleton Skeleton;
	public TArray<FPreviewMeshCollectionEntry> SkeletalMeshes;
}
