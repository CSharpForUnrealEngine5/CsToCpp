namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("FindTurnBasedMatchCallbackProxy.h")]
public partial class UFindTurnBasedMatchCallbackProxy : UOnlineBlueprintCallProxyBase {
	public static UClass StaticClass() {return default;}
	///<summary>Called when matchmaking succeeded.</summary>
	public FOnlineTurnBasedMatchResult OnSuccess;
	///<summary>Called when matchmaking failed</summary>
	public FOnlineTurnBasedMatchResult OnFailure;
	///<summary>Use the platform matchmaking service (like Game Center) to find a match.</summary>
	public static UFindTurnBasedMatchCallbackProxy FindTurnBasedMatch(UObject WorldContextObject,APlayerController PlayerController,object /*MatchActor*/ MatchActor,int MinPlayers,int MaxPlayers,int PlayerGroup,bool ShowExistingMatches) { return default; }
}
