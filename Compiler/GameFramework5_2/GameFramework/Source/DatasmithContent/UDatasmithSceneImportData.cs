#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Base class for import data and options used when importing any asset from Datasmith</summary>
[CppInclude("DatasmithAssetImportData.h")]
public partial class UDatasmithSceneImportData : UAssetImportData {
	///<summary>BaseOptions</summary>
	public FDatasmithImportBaseOptions BaseOptions;
	///<summary>DatasmithImportInfo</summary>
	public FDatasmithImportInfo DatasmithImportInfo;
}
