namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MuCO/CustomizableObjectClothingTypes.h")]
public partial struct FCustomizableObjectClothingAssetData {
	public TArray<FClothLODDataCommon> LodData;
	public TArray<int> LodMap;
	public TArray<string> UsedBoneNames;
	public TArray<int> UsedBoneIndices;
	public int ReferenceBoneIndex;
	public TArray<FCustomizableObjectClothConfigData> ConfigsData;
	public string PhysicsAssetPath;
	public string Name;
	public FGuid OriginalAssetGuid;
}
