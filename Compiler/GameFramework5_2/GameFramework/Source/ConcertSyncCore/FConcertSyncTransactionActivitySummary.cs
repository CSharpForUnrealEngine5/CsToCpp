namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Summary for a transaction activity entry in a Concert Sync Session</summary>
[CppInclude("ConcertSyncSessionTypes.h")]
public partial struct FConcertSyncTransactionActivitySummary {
	public EConcertSyncTransactionActivitySummaryType TransactionSummaryType;
	public FText TransactionTitle;
	public FName PrimaryObjectName;
	public FName PrimaryPackageName;
	public FName NewObjectName;
	public int NumActions;
}
