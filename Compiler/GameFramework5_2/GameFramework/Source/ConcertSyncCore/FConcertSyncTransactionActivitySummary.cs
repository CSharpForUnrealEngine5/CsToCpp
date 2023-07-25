#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ConcertSyncSessionTypes.h")]
///<summary>Summary for a transaction activity entry in a Concert Sync Session</summary>
public partial struct FConcertSyncTransactionActivitySummary {
// ConcertSyncTransactionActivitySummary
	public EConcertSyncTransactionActivitySummaryType TransactionSummaryType;
	public string TransactionTitle;
	public string PrimaryObjectName;
	public string PrimaryPackageName;
	public string NewObjectName;
	public int NumActions;
}
