namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>An entry in a preview mesh collection</summary>
[CppInclude("Engine/PreviewMeshCollection.h")]
public partial struct FPreviewMeshCollectionEntry {
	public TSoftObjectPtr<USkeletalMesh> SkeletalMesh;
	public TSoftObjectPtr<UAnimBlueprint> AnimBlueprint;
}
