namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("EndTurnCallbackProxy.h")]
public partial class UEndTurnCallbackProxy : UOnlineBlueprintCallProxyBase {
	public static UClass StaticClass() {return default;}
	///<summary>Called when there is a successful query</summary>
	public FEmptyOnlineDelegate OnSuccess;
	///<summary>Called when there is an unsuccessful query</summary>
	public FEmptyOnlineDelegate OnFailure;
	///<summary>Ends the turn for the current player</summary>
	public static UEndTurnCallbackProxy EndTurn(UObject WorldContextObject,APlayerController PlayerController,string MatchID,object /*TurnBasedMatchInterface*/ TurnBasedMatchInterface) { return default; }
}
