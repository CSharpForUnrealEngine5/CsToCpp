#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ClothingAsset.h")]
///<summary>Implementation of non-solver specific, but common Engine related functionality.</summary>
public partial class UClothingAssetCommon : UClothingAssetBase {
// ClothingAssetCommon
	public UPhysicsAsset PhysicsAsset;
	public TMap<string,UClothConfigBase> ClothConfigs;
	public UClothConfigBase ClothSharedSimConfig_DEPRECATED;
	public UClothConfigBase ClothSimConfig_DEPRECATED;
	public UClothConfigBase ChaosClothSimConfig_DEPRECATED;
	public TArray<UClothLODDataCommon_Legacy> ClothLodData_DEPRECATED;
	public TArray<FClothLODDataCommon> LodData;
	public TArray<int> LodMap;
	public TArray<string> UsedBoneNames;
	public TArray<int> UsedBoneIndices;
	public int ReferenceBoneIndex;
	public UClothingAssetCustomData CustomData;
	public FClothConfig_Legacy ClothConfig_DEPRECATED;
}
