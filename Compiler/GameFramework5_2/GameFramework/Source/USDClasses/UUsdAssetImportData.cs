namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("USDAssetImportData.h")]
public partial class UUsdAssetImportData : UAssetImportData {
	public static UClass StaticClass() {return default;}
	///<summary>PrimPath</summary>
	public string PrimPath;
	///<summary>Likely a UUSDStageImportOptions, but we don&#39;t declare it here</summary>
	public UObject ImportOptions;
}
