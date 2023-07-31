#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("QuitMatchCallbackProxy.h")]
public partial class UQuitMatchCallbackProxy : UOnlineBlueprintCallProxyBase {
	///<summary>Called when there is a successful query</summary>
	public FEmptyOnlineDelegate OnSuccess;
	///<summary>Called when there is an unsuccessful query</summary>
	public FEmptyOnlineDelegate OnFailure;
	///<summary>Quits the turn based match</summary>
	public static UQuitMatchCallbackProxy QuitMatch(UObject WorldContextObject,APlayerController PlayerController,string MatchID,EMPMatchOutcome Outcome,int TurnTimeoutInSeconds) { return default; }
}
