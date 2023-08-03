#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Implementation of non-solver specific, but common Engine related functionality.</summary>
[CppInclude("ClothingAsset.h")]
public partial class UClothingAssetCommon : UClothingAssetBase {
	public static UClass StaticClass() {return default;}
	///<summary>The physics asset to extract collisions from when building a simulation.</summary>
	public UPhysicsAsset PhysicsAsset;
	///<summary>Simulation specific cloth parameters.</summary>
	public TMap<string,UClothConfigBase> ClothConfigs;
	///<summary>Shared by all cloth instances in a skeletal mesh</summary>
	public UClothConfigBase ClothSharedSimConfig_DEPRECATED;
	///<summary>Parameters for how the NVcloth behaves.</summary>
	public UClothConfigBase ClothSimConfig_DEPRECATED;
	///<summary>Parameters for how Chaos cloth behaves</summary>
	public UClothConfigBase ChaosClothSimConfig_DEPRECATED;
	///<summary>Deprecated. Use LodData instead</summary>
	public TArray<UClothLODDataCommon_Legacy> ClothLodData_DEPRECATED;
	///<summary>The actual asset data, listed by LOD.</summary>
	public TArray<FClothLODDataCommon> LodData;
	///<summary>Tracks which clothing LOD each skel mesh LOD corresponds to (LodMap[SkelLod]=ClothingLod).</summary>
	public TArray<int> LodMap;
	///<summary>List of bones this asset uses inside its parent mesh.</summary>
	public TArray<string> UsedBoneNames;
	///<summary>List of the indices for the bones in UsedBoneNames, used for remapping.</summary>
	public TArray<int> UsedBoneIndices;
	///<summary>Bone to treat as the root of the simulation space.</summary>
	public int ReferenceBoneIndex;
	///<summary>Custom data applied by the importer depending on where the asset was imported from.</summary>
	public UClothingAssetCustomData CustomData;
	///<summary>Deprecated property for transitioning the \c FClothConfig struct to the</summary>
	public FClothConfig_Legacy ClothConfig_DEPRECATED;
}
