#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Component that can be used to perform Skeletal Mesh merges from Blueprints.</summary>
[CppInclude("SkeletalMergingLibrary.h")]
public partial class USkeletalMergingLibrary : UBlueprintFunctionLibrary {
	public static UClass StaticClass() {return default;}
	///<summary>Merges the given meshes into a single mesh.</summary>
	public static USkeletalMesh MergeMeshes(FSkeletalMeshMergeParams Params) { return default; }
	///<summary>Merges the skeletons for the provided meshes into a single skeleton.</summary>
	public static USkeleton MergeSkeletons(FSkeletonMergeParams Params) { return default; }
}
