#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/DataTable.h")]
///<summary>Imported spreadsheet table.</summary>
public partial class UDataTable : UObject {
// DataTable
	public UScriptStruct RowStruct;
	public bool bStripFromClientBuilds;
	public bool bIgnoreExtraFields;
	public bool bIgnoreMissingFields;
	public string ImportKeyField;
	public UAssetImportData AssetImportData;
	public string ImportPath_DEPRECATED;
	public string RowStructName_DEPRECATED;
	public FTopLevelAssetPath RowStructPathName;
	public TArray<byte> RowsSerializedWithTags;
	public TSet<UObject> TemporarilyReferencedObjects;
}
