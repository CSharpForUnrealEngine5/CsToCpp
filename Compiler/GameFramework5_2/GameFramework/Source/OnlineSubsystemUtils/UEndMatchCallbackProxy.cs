#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("EndMatchCallbackProxy.h")]
public partial class UEndMatchCallbackProxy : UOnlineBlueprintCallProxyBase {
	public static UClass StaticClass() {return default;}
	///<summary>Called when the match ends successfully</summary>
	public FEmptyOnlineDelegate OnSuccess;
	///<summary>Called when ending the match fails</summary>
	public FEmptyOnlineDelegate OnFailure;
	///<summary>End a match that is in progress while it is the current player&#39;s turn</summary>
	public static UEndMatchCallbackProxy EndMatch(UObject WorldContextObject,APlayerController PlayerController,object /*MatchActor*/ MatchActor,string MatchID,EMPMatchOutcome LocalPlayerOutcome,EMPMatchOutcome OtherPlayersOutcome) { return default; }
}
