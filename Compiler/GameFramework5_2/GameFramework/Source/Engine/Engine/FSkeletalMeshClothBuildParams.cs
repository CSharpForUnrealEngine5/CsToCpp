namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Struct holding parameters needed when creating a new clothing asset or sub asset (LOD)</summary>
[CppInclude("Engine/SkeletalMesh.h")]
public partial struct FSkeletalMeshClothBuildParams {
	public TWeakObjectPtr<UClothingAssetBase> TargetAsset;
	public int TargetLod;
	public bool bRemapParameters;
	public string AssetName;
	public int LodIndex;
	public int SourceSection;
	public bool bRemoveFromMesh;
	public TSoftObjectPtr<UPhysicsAsset> PhysicsAsset;
}
