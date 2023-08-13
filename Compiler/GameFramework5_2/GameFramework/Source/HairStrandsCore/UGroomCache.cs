namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Implements an asset that is used to store an animated groom</summary>
[CppInclude("GroomCache.h")]
public partial class UGroomCache : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Import options used for this GroomCache</summary>
	public UAssetImportData AssetImportData;
	///<summary>GroomCacheInfo</summary>
	public FGroomCacheInfo GroomCacheInfo;
}
