#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DataRegistrySubsystem.h")]
///<summary>Singleton manager that provides synchronous and asynchronous access to data registries</summary>
public partial class UDataRegistrySubsystem : UEngineSubsystem {
// DataRegistrySubsystem
	public static bool GetCachedItemBP(FDataRegistryId ItemId,FTableRowBase OutItem) { return default; }
	public static void FindCachedItemBP(FDataRegistryId ItemId,EDataRegistrySubsystemGetItemResult OutResult,FTableRowBase OutItem) {}
	public static bool GetCachedItemFromLookupBP(FDataRegistryId ItemId,FDataRegistryLookup ResolvedLookup,FTableRowBase OutItem) { return default; }
	public static bool AcquireItemBP(FDataRegistryId ItemId,FDataRegistryItemAcquiredBPCallback AcquireCallback) { return default; }
	public static void EvaluateDataRegistryCurve(FDataRegistryId ItemId,float InputValue,float DefaultValue,EDataRegistrySubsystemGetItemResult OutResult,float OutValue) {}
	public static bool IsValidDataRegistryType(FDataRegistryType DataRegistryType) { return default; }
	public static string Conv_DataRegistryTypeToString(FDataRegistryType DataRegistryType) { return default; }
	public static bool EqualEqual_DataRegistryType(FDataRegistryType A,FDataRegistryType B) { return default; }
	public static bool NotEqual_DataRegistryType(FDataRegistryType A,FDataRegistryType B) { return default; }
	public static bool IsValidDataRegistryId(FDataRegistryId DataRegistryId) { return default; }
	public static string Conv_DataRegistryIdToString(FDataRegistryId DataRegistryId) { return default; }
	public static bool EqualEqual_DataRegistryId(FDataRegistryId A,FDataRegistryId B) { return default; }
	public static bool NotEqual_DataRegistryId(FDataRegistryId A,FDataRegistryId B) { return default; }
}
