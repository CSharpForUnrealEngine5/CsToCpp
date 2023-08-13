namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("QuitMatchCallbackProxy.h")]
public partial class UQuitMatchCallbackProxy : UOnlineBlueprintCallProxyBase {
	public static UClass StaticClass() {return default;}
	///<summary>Called when there is a successful query</summary>
	public FEmptyOnlineDelegate OnSuccess;
	///<summary>Called when there is an unsuccessful query</summary>
	public FEmptyOnlineDelegate OnFailure;
	///<summary>Quits the turn based match</summary>
	public static UQuitMatchCallbackProxy QuitMatch(UObject WorldContextObject,APlayerController PlayerController,string MatchID,EMPMatchOutcome Outcome,int TurnTimeoutInSeconds) { return default; }
}
