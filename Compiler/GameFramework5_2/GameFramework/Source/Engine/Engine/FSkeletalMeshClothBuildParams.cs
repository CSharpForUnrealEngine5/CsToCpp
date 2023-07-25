#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/SkeletalMesh.h")]
///<summary>Struct holding parameters needed when creating a new clothing asset or sub asset (LOD)</summary>
public partial struct FSkeletalMeshClothBuildParams {
// SkeletalMeshClothBuildParams
	public TWeakObjectPtr<UClothingAssetBase> TargetAsset;
	public int TargetLod;
	public bool bRemapParameters;
	public string AssetName;
	public int LodIndex;
	public int SourceSection;
	public bool bRemoveFromMesh;
	public TSoftObjectPtr<UPhysicsAsset> PhysicsAsset;
}
