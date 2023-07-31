#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>An entry in a preview mesh collection</summary>
[CppInclude("Engine/PreviewMeshCollection.h")]
public partial struct FPreviewMeshCollectionEntry {
	public TSoftObjectPtr<USkeletalMesh> SkeletalMesh;
	public TSoftObjectPtr<UAnimBlueprint> AnimBlueprint;
}
