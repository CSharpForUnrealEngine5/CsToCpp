namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ConcertSyncSettings.h")]
public partial class UConcertSyncConfig : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Should we ask before hot-reloading changed packages?</summary>
	public bool bInteractiveHotReload;
	///<summary>Should we show presence when in PIE?</summary>
	public bool bShowPresenceInPIE;
	///<summary>Should we include object changes that have been generated via a transaction annotation</summary>
	public bool bIncludeAnnotationObjectChanges;
	///<summary>Number of snapshot transactions (eg, moving an object or dragging a slider) that should be sent per-second to other clients.</summary>
	public float SnapshotTransactionsPerSecond;
	///<summary>Array of Transaction class filter.</summary>
	public TArray<FTransactionClassFilter> IncludeObjectClassFilters;
	///<summary>Array of additional Transaction class filter.</summary>
	public TArray<FTransactionClassFilter> ExcludeTransactionClassFilters;
	///<summary>Array of transient class properties that we should send transaction updates for even if usually filtered out.</summary>
	public TArray<object> AllowedTransientProperties;
	///<summary>Array of class properties that we should filtered out.</summary>
	public TArray<object> ExcludedProperties;
	///<summary>Array of package class filter.</summary>
	public TArray<FPackageClassFilter> ExcludePackageClassFilters;
}
