#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>UAssetMappingTable : that has AssetMappingTableging data</summary>
[CppInclude("Animation/AssetMappingTable.h")]
public partial class UAssetMappingTable : UObject {
	///<summary>Mappin of asset between source and target *</summary>
	public TArray<FAssetMapping> MappedAssets;
}
