#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Singleton manager that provides synchronous and asynchronous access to data registries</summary>
[CppInclude("DataRegistrySubsystem.h")]
public partial class UDataRegistrySubsystem : UEngineSubsystem {
	///<summary>Attempts to get cached structure data stored in a DataRegistry, modifying OutItem if the item is available</summary>
	public static bool GetCachedItemBP(FDataRegistryId ItemId,FTableRowBase OutItem) { return default; }
	///<summary>Attempts to get cached structure data stored in a DataRegistry, modifying OutItem if the item is available</summary>
	public static void FindCachedItemBP(FDataRegistryId ItemId,EDataRegistrySubsystemGetItemResult OutResult,FTableRowBase OutItem) {}
	///<summary>Attempts to get structure data stored in a DataRegistry cache after an async acquire, modifying OutItem if the item is available</summary>
	public static bool GetCachedItemFromLookupBP(FDataRegistryId ItemId,FDataRegistryLookup ResolvedLookup,FTableRowBase OutItem) { return default; }
	///<summary>Starts an asynchronous acquire of a data registry item that may not yet be cached.</summary>
	public static bool AcquireItemBP(FDataRegistryId ItemId,FDataRegistryItemAcquiredBPCallback AcquireCallback) { return default; }
	///<summary>Attempts to evaluate a curve stored in a DataRegistry cache using a specific input value</summary>
	public static void EvaluateDataRegistryCurve(FDataRegistryId ItemId,float InputValue,float DefaultValue,EDataRegistrySubsystemGetItemResult OutResult,float OutValue) {}
	///<summary>Returns true if this is a non-empty type, does not check if it is currently registered</summary>
	public static bool IsValidDataRegistryType(FDataRegistryType DataRegistryType) { return default; }
	///<summary>Converts a Data Registry Type to a string. The other direction is not provided because it cannot be validated</summary>
	public static string Conv_DataRegistryTypeToString(FDataRegistryType DataRegistryType) { return default; }
	///<summary>Returns true if the values are equal (A == B)</summary>
	public static bool EqualEqual_DataRegistryType(FDataRegistryType A,FDataRegistryType B) { return default; }
	///<summary>Returns true if the values are not equal (A != B)</summary>
	public static bool NotEqual_DataRegistryType(FDataRegistryType A,FDataRegistryType B) { return default; }
	///<summary>Returns true if this is a non-empty item identifier, does not check if it is currently registered</summary>
	public static bool IsValidDataRegistryId(FDataRegistryId DataRegistryId) { return default; }
	///<summary>Converts a Data Registry Id to a string. The other direction is not provided because it cannot be validated</summary>
	public static string Conv_DataRegistryIdToString(FDataRegistryId DataRegistryId) { return default; }
	///<summary>Returns true if the values are equal (A == B)</summary>
	public static bool EqualEqual_DataRegistryId(FDataRegistryId A,FDataRegistryId B) { return default; }
	///<summary>Returns true if the values are not equal (A != B)</summary>
	public static bool NotEqual_DataRegistryId(FDataRegistryId A,FDataRegistryId B) { return default; }
}
