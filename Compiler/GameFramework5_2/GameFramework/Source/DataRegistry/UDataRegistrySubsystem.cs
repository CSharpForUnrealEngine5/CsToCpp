#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DataRegistrySubsystem.h")]
///<summary>Singleton manager that provides synchronous and asynchronous access to data registries</summary>
public partial class UDataRegistrySubsystem : UEngineSubsystem {
// DataRegistrySubsystem
	public bool GetCachedItemBP(FDataRegistryId ItemId,FTableRowBase OutItem) { return default; }
	public void FindCachedItemBP(FDataRegistryId ItemId,EDataRegistrySubsystemGetItemResult OutResult,FTableRowBase OutItem) {}
	public bool GetCachedItemFromLookupBP(FDataRegistryId ItemId,FDataRegistryLookup ResolvedLookup,FTableRowBase OutItem) { return default; }
	public bool AcquireItemBP(FDataRegistryId ItemId,FDataRegistryItemAcquiredBPCallback AcquireCallback) { return default; }
	public void EvaluateDataRegistryCurve(FDataRegistryId ItemId,float InputValue,float DefaultValue,EDataRegistrySubsystemGetItemResult OutResult,float OutValue) {}
	public bool IsValidDataRegistryType(FDataRegistryType DataRegistryType) { return default; }
	public string Conv_DataRegistryTypeToString(FDataRegistryType DataRegistryType) { return default; }
	public bool EqualEqual_DataRegistryType(FDataRegistryType A,FDataRegistryType B) { return default; }
	public bool NotEqual_DataRegistryType(FDataRegistryType A,FDataRegistryType B) { return default; }
	public bool IsValidDataRegistryId(FDataRegistryId DataRegistryId) { return default; }
	public string Conv_DataRegistryIdToString(FDataRegistryId DataRegistryId) { return default; }
	public bool EqualEqual_DataRegistryId(FDataRegistryId A,FDataRegistryId B) { return default; }
	public bool NotEqual_DataRegistryId(FDataRegistryId A,FDataRegistryId B) { return default; }
}
