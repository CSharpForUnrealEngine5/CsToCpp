#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Kismet/KismetStringTableLibrary.h")]
public partial class UKismetStringTableLibrary : UBlueprintFunctionLibrary {
// KismetStringTableLibrary
	public bool IsRegisteredTableId(string TableId) { return default; }
	public bool IsRegisteredTableEntry(string TableId,string Key) { return default; }
	public string GetTableNamespace(string TableId) { return default; }
	public string GetTableEntrySourceString(string TableId,string Key) { return default; }
	public string GetTableEntryMetaData(string TableId,string Key,string MetaDataId) { return default; }
	public TArray<string> GetRegisteredStringTables() { return default; }
	public TArray<string> GetKeysFromStringTable(string TableId) { return default; }
	public TArray<string> GetMetaDataIdsFromStringTableEntry(string TableId,string Key) { return default; }
}
