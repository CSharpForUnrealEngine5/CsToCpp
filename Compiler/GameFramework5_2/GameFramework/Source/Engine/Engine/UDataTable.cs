#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Imported spreadsheet table.</summary>
[CppInclude("Engine/DataTable.h")]
public partial class UDataTable : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Structure to use for each row of the table, must inherit from FTableRowBase</summary>
	public UScriptStruct RowStruct;
	///<summary>Set to true to not cook this data table into client builds. Useful for sensitive tables that only servers should know about.</summary>
	public bool bStripFromClientBuilds;
	///<summary>Set to true to ignore extra fields in the import data, if false it will warn about them</summary>
	public bool bIgnoreExtraFields;
	///<summary>Set to true to ignore any fields that are expected but missing, if false it will warn about them</summary>
	public bool bIgnoreMissingFields;
	///<summary>Explicit field in import data to use as key. If this is empty it uses Name for JSON and the first field found for CSV</summary>
	public string ImportKeyField;
	///<summary>The file this data table was imported from, may be empty</summary>
	public UAssetImportData AssetImportData;
	///<summary>The filename imported to create this object. Relative to this object&#39;s package, BaseDir() or absolute</summary>
	public string ImportPath_DEPRECATED;
	///<summary>The name of the RowStruct we were using when we were last saved</summary>
	public string RowStructName_DEPRECATED;
	///<summary>The name of the RowStruct we were using when we were last saved</summary>
	public FTopLevelAssetPath RowStructPathName;
	///<summary>When RowStruct is being modified, row data is stored serialized with tags</summary>
	public TArray<byte> RowsSerializedWithTags;
	///<summary>TemporarilyReferencedObjects</summary>
	public TSet<UObject> TemporarilyReferencedObjects;
}
