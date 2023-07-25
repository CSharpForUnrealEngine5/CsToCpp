#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/PreviewMeshCollection.h")]
///<summary>An entry in a preview mesh collection</summary>
public partial struct FPreviewMeshCollectionEntry {
// PreviewMeshCollectionEntry
	public TSoftObjectPtr<USkeletalMesh> SkeletalMesh;
	public TSoftObjectPtr<UAnimBlueprint> AnimBlueprint;
}
