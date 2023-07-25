#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DataRegistrySource.h")]
///<summary>Base class for a data source that generates additional data sources at runtime</summary>
public partial class UMetaDataRegistrySource : UDataRegistrySource {
// MetaDataRegistrySource
	public EMetaDataRegistrySourceAssetUsage AssetUsage;
	public FAssetManagerSearchRules SearchRules;
	public TMap<string,UDataRegistrySource> RuntimeChildren;
}
