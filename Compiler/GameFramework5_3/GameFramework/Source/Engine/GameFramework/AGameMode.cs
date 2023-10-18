namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>GameMode is a subclass of GameModeBase that behaves like a multiplayer match-based game.</summary>
[CppInclude("GameFramework/GameMode.h")]
public partial class AGameMode : AGameModeBase {
	public static UClass StaticClass() {return default;}
	///<summary>Returns the current match state, this is an accessor to protect the state machine flow</summary>
	public FName GetMatchState() { return default; }
	///<summary>Returns true if the match state is InProgress or other gameplay state</summary>
	public virtual bool IsMatchInProgress() { return default; }
	///<summary>Transition from WaitingToStart to InProgress. You can call this manually, will also get called if ReadyToStartMatch returns true</summary>
	public virtual void StartMatch() {}
	///<summary>Transition from InProgress to WaitingPostMatch. You can call this manually, will also get called if ReadyToEndMatch returns true</summary>
	public virtual void EndMatch() {}
	///<summary>Restart the game, by default travel to the current map</summary>
	public virtual void RestartGame() {}
	///<summary>Report that a match has failed due to unrecoverable error</summary>
	public virtual void AbortMatch() {}
	///<summary>What match state we are currently in</summary>
	public FName MatchState;
	///<summary>Implementable event to respond to match state changes</summary>
	public void K2_OnSetMatchState(FName NewState) {}
	///<summary>Returns true if ready to Start Match. Games should override this</summary>
	public bool ReadyToStartMatch() { return default; }
	///<summary>Returns true if ready to End Match. Games should override this</summary>
	public bool ReadyToEndMatch() { return default; }
	///<summary>Whether the game should immediately start when the first player logs in. Affects the default behavior of ReadyToStartMatch</summary>
	public bool bDelayedStart;
	///<summary>Current number of spectators.</summary>
	public int NumSpectators;
	///<summary>Current number of human players.</summary>
	public int NumPlayers;
	///<summary>number of non-human players (AI controlled but participating as a player).</summary>
	public int NumBots;
	///<summary>Minimum time before player can respawn after dying.</summary>
	public float MinRespawnDelay;
	///<summary>Number of players that are still traveling from a previous map</summary>
	public int NumTravellingPlayers;
	///<summary>Contains strings describing localized game agnostic messages.</summary>
	public UClass EngineMessageClass;
	///<summary>PlayerStates of players who have disconnected from the server (saved in case they reconnect)</summary>
	public TArray<APlayerState> InactivePlayerArray;
	///<summary>Time a playerstate will stick around in an inactive state after a player logout</summary>
	public float InactivePlayerStateLifeSpan;
	///<summary>The maximum number of inactive players before we kick the oldest ones out</summary>
	public int MaxInactivePlayers;
	///<summary>If true, dedicated servers will record replays when HandleMatchHasStarted/HandleMatchHasStopped is called</summary>
	public bool bHandleDedicatedServerReplays;
	///<summary>Exec command to broadcast a string to all players</summary>
	public virtual void Say(string Msg) {}
}
