#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("FindTurnBasedMatchCallbackProxy.h")]
public partial class UFindTurnBasedMatchCallbackProxy : UOnlineBlueprintCallProxyBase {
// FindTurnBasedMatchCallbackProxy
	public FOnlineTurnBasedMatchResult OnSuccess;
	public FOnlineTurnBasedMatchResult OnFailure;
	public static UFindTurnBasedMatchCallbackProxy FindTurnBasedMatch(UObject WorldContextObject,APlayerController PlayerController,object /*MatchActor*/ MatchActor,int MinPlayers,int MaxPlayers,int PlayerGroup,bool ShowExistingMatches) { return default; }
}
