namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>UAssetMappingTable : that has AssetMappingTableging data</summary>
[CppInclude("Animation/AssetMappingTable.h")]
public partial class UAssetMappingTable : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Mappin of asset between source and target *</summary>
	public TArray<FAssetMapping> MappedAssets;
}
