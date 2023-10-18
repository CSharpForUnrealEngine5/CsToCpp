namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DatasmithAssetImportData.h")]
public partial class UDatasmithAssetImportData : UAssetImportData {
	public static UClass StaticClass() {return default;}
	///<summary>AssetImportOptions</summary>
	public FDatasmithAssetImportOptions AssetImportOptions;
	///<summary>AdditionalData</summary>
	public TArray<UDatasmithAdditionalData> AdditionalData;
	///<summary>DatasmithImportInfo</summary>
	public FDatasmithImportInfo DatasmithImportInfo;
}
