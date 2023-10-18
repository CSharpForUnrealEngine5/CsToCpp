namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Kismet/KismetStringTableLibrary.h")]
public partial class UKismetStringTableLibrary : UBlueprintFunctionLibrary {
	public static UClass StaticClass() {return default;}
	///<summary>Returns true if the given table ID corresponds to a registered string table.</summary>
	public static bool IsRegisteredTableId(FName TableId) { return default; }
	///<summary>Returns true if the given table ID corresponds to a registered string table, and that table has.</summary>
	public static bool IsRegisteredTableEntry(FName TableId,string Key) { return default; }
	///<summary>Returns the namespace of the given string table.</summary>
	public static string GetTableNamespace(FName TableId) { return default; }
	///<summary>Returns the source string of the given string table entry (or an empty string).</summary>
	public static string GetTableEntrySourceString(FName TableId,string Key) { return default; }
	///<summary>Returns the specified meta-data of the given string table entry (or an empty string).</summary>
	public static string GetTableEntryMetaData(FName TableId,string Key,FName MetaDataId) { return default; }
	///<summary>Returns an array of all registered string table IDs</summary>
	public static TArray<FName> GetRegisteredStringTables() { return default; }
	///<summary>Returns an array of all keys within the given string table</summary>
	public static TArray<string> GetKeysFromStringTable(FName TableId) { return default; }
	///<summary>Returns an array of all meta-data IDs within the given string table entry</summary>
	public static TArray<FName> GetMetaDataIdsFromStringTableEntry(FName TableId,string Key) { return default; }
}
