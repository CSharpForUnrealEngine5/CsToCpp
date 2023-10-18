namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("LeaderboardFlushCallbackProxy.h")]
public partial class ULeaderboardFlushCallbackProxy : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Called when there is a successful leaderboard flush</summary>
	public FOnLeaderboardFlushed OnSuccess;
	///<summary>Called when there is an unsuccessful leaderboard flush</summary>
	public FOnLeaderboardFlushed OnFailure;
	///<summary>Called to perform the query internally</summary>
	public static ULeaderboardFlushCallbackProxy CreateProxyObjectForFlush(APlayerController PlayerController,FName SessionName) { return default; }
}
