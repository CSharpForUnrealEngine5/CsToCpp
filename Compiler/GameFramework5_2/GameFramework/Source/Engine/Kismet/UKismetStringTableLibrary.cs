namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Kismet/KismetStringTableLibrary.h")]
public partial class UKismetStringTableLibrary : UBlueprintFunctionLibrary {
	public static UClass StaticClass() {return default;}
	///<summary>Returns true if the given table ID corresponds to a registered string table.</summary>
	public static bool IsRegisteredTableId(string TableId) { return default; }
	///<summary>Returns true if the given table ID corresponds to a registered string table, and that table has.</summary>
	public static bool IsRegisteredTableEntry(string TableId,string Key) { return default; }
	///<summary>Returns the namespace of the given string table.</summary>
	public static string GetTableNamespace(string TableId) { return default; }
	///<summary>Returns the source string of the given string table entry (or an empty string).</summary>
	public static string GetTableEntrySourceString(string TableId,string Key) { return default; }
	///<summary>Returns the specified meta-data of the given string table entry (or an empty string).</summary>
	public static string GetTableEntryMetaData(string TableId,string Key,string MetaDataId) { return default; }
	///<summary>Returns an array of all registered string table IDs</summary>
	public static TArray<string> GetRegisteredStringTables() { return default; }
	///<summary>Returns an array of all keys within the given string table</summary>
	public static TArray<string> GetKeysFromStringTable(string TableId) { return default; }
	///<summary>Returns an array of all meta-data IDs within the given string table entry</summary>
	public static TArray<string> GetMetaDataIdsFromStringTableEntry(string TableId,string Key) { return default; }
}
