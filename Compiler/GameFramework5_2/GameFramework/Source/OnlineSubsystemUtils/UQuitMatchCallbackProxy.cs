#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("QuitMatchCallbackProxy.h")]
public partial class UQuitMatchCallbackProxy : UOnlineBlueprintCallProxyBase {
// QuitMatchCallbackProxy
	public FEmptyOnlineDelegate OnSuccess;
	public FEmptyOnlineDelegate OnFailure;
	public static UQuitMatchCallbackProxy QuitMatch(UObject WorldContextObject,APlayerController PlayerController,string MatchID,EMPMatchOutcome Outcome,int TurnTimeoutInSeconds) { return default; }
}
