#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("LeaderboardFlushCallbackProxy.h")]
public partial class ULeaderboardFlushCallbackProxy : UObject {
	///<summary>Called when there is a successful leaderboard flush</summary>
	public FOnLeaderboardFlushed OnSuccess;
	///<summary>Called when there is an unsuccessful leaderboard flush</summary>
	public FOnLeaderboardFlushed OnFailure;
	///<summary>Called to perform the query internally</summary>
	public static ULeaderboardFlushCallbackProxy CreateProxyObjectForFlush(APlayerController PlayerController,string SessionName) { return default; }
}
