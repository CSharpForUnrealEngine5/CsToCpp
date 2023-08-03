#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A simple collection of skeletal meshes used for in-editor preview</summary>
[CppInclude("Engine/PreviewMeshCollection.h")]
public partial class UPreviewMeshCollection : UDataAsset {
	public static UClass StaticClass() {return default;}
	///<summary>Skeleton</summary>
	public USkeleton Skeleton;
	///<summary>The skeletal meshes that this collection contains</summary>
	public TArray<FPreviewMeshCollectionEntry> SkeletalMeshes;
}
