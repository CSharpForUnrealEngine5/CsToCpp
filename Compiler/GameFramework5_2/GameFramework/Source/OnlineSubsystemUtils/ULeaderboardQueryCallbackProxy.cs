#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("LeaderboardQueryCallbackProxy.h")]
public partial class ULeaderboardQueryCallbackProxy : UObject {
	///<summary>Called when there is a successful leaderboard query</summary>
	public FLeaderboardQueryResult OnSuccess;
	///<summary>Called when there is an unsuccessful leaderboard query</summary>
	public FLeaderboardQueryResult OnFailure;
	///<summary>Queries a leaderboard for an integer value</summary>
	public static ULeaderboardQueryCallbackProxy CreateProxyObjectForIntQuery(APlayerController PlayerController,string StatName) { return default; }
}
