#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Base class for a data source that generates additional data sources at runtime</summary>
[CppInclude("DataRegistrySource.h")]
public partial class UMetaDataRegistrySource : UDataRegistrySource {
	public static UClass StaticClass() {return default;}
	///<summary>Asset usage</summary>
	public EMetaDataRegistrySourceAssetUsage AssetUsage;
	///<summary>Asset registry scan rules</summary>
	public FAssetManagerSearchRules SearchRules;
	///<summary>Map from source identifier such as package name to registered child</summary>
	public TMap<string,UDataRegistrySource> RuntimeChildren;
}
