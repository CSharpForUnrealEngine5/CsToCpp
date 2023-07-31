#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Summary for a transaction activity entry in a Concert Sync Session</summary>
[CppInclude("ConcertSyncSessionTypes.h")]
public partial struct FConcertSyncTransactionActivitySummary {
	public EConcertSyncTransactionActivitySummaryType TransactionSummaryType;
	public string TransactionTitle;
	public string PrimaryObjectName;
	public string PrimaryPackageName;
	public string NewObjectName;
	public int NumActions;
}
