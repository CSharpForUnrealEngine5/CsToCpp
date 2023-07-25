#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ConcertSyncSettings.h")]
public partial class UConcertSyncConfig : UObject {
// ConcertSyncConfig
	public bool bInteractiveHotReload;
	public bool bShowPresenceInPIE;
	public bool bIncludeAnnotationObjectChanges;
	public float SnapshotTransactionsPerSecond;
	public TArray<FTransactionClassFilter> IncludeObjectClassFilters;
	public TArray<FTransactionClassFilter> ExcludeTransactionClassFilters;
	public TArray<object> AllowedTransientProperties;
	public TArray<FPackageClassFilter> ExcludePackageClassFilters;
}
