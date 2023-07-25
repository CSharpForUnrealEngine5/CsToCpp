#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("EndTurnCallbackProxy.h")]
public partial class UEndTurnCallbackProxy : UOnlineBlueprintCallProxyBase {
// EndTurnCallbackProxy
	public FEmptyOnlineDelegate OnSuccess;
	public FEmptyOnlineDelegate OnFailure;
	public UObject EndTurn(UObject WorldContextObject,UObject PlayerController,string MatchID,object /*TurnBasedMatchInterface*/ TurnBasedMatchInterface) { return default; }
}
