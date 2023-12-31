namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>The asset import data to store the import settings within the GroomCache asset</summary>
[CppInclude("GroomCacheImportOptions.h")]
public partial class UGroomCacheImportData : UAssetImportData {
	public static UClass StaticClass() {return default;}
	///<summary>Settings</summary>
	public FGroomCacheImportSettings Settings;
}
