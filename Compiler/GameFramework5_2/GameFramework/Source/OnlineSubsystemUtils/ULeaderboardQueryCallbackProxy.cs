#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("LeaderboardQueryCallbackProxy.h")]
public partial class ULeaderboardQueryCallbackProxy : UObject {
// LeaderboardQueryCallbackProxy
	public FLeaderboardQueryResult OnSuccess;
	public FLeaderboardQueryResult OnFailure;
	public static ULeaderboardQueryCallbackProxy CreateProxyObjectForIntQuery(APlayerController PlayerController,string StatName) { return default; }
}
