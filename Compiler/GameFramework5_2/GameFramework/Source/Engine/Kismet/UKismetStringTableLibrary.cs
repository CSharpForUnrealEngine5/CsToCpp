#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Kismet/KismetStringTableLibrary.h")]
public partial class UKismetStringTableLibrary : UBlueprintFunctionLibrary {
// KismetStringTableLibrary
	public static bool IsRegisteredTableId(string TableId) { return default; }
	public static bool IsRegisteredTableEntry(string TableId,string Key) { return default; }
	public static string GetTableNamespace(string TableId) { return default; }
	public static string GetTableEntrySourceString(string TableId,string Key) { return default; }
	public static string GetTableEntryMetaData(string TableId,string Key,string MetaDataId) { return default; }
	public static TArray<string> GetRegisteredStringTables() { return default; }
	public static TArray<string> GetKeysFromStringTable(string TableId) { return default; }
	public static TArray<string> GetMetaDataIdsFromStringTableEntry(string TableId,string Key) { return default; }
}
