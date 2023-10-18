namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Base class for import data and options used when importing any asset from Datasmith</summary>
[CppInclude("DatasmithAssetImportData.h")]
public partial class UDatasmithSceneImportData : UAssetImportData {
	public static UClass StaticClass() {return default;}
	///<summary>BaseOptions</summary>
	public FDatasmithImportBaseOptions BaseOptions;
	///<summary>DatasmithImportInfo</summary>
	public FDatasmithImportInfo DatasmithImportInfo;
}
