#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GameFramework/GameMode.h")]
///<summary>GameMode is a subclass of GameModeBase that behaves like a multiplayer match-based game.</summary>
public partial class AGameMode : AGameModeBase {
// GameMode
	public string GetMatchState() { return default; }
	public bool IsMatchInProgress() { return default; }
	public void StartMatch() {}
	public void EndMatch() {}
	public void RestartGame() {}
	public void AbortMatch() {}
	public string MatchState;
	public void K2_OnSetMatchState(string NewState) {}
	public bool ReadyToStartMatch() { return default; }
	public bool ReadyToEndMatch() { return default; }
	public bool bDelayedStart;
	public int NumSpectators;
	public int NumPlayers;
	public int NumBots;
	public float MinRespawnDelay;
	public int NumTravellingPlayers;
	public UClass EngineMessageClass;
	public TArray<APlayerState> InactivePlayerArray;
	public float InactivePlayerStateLifeSpan;
	public int MaxInactivePlayers;
	public bool bHandleDedicatedServerReplays;
	public void Say(string Msg) {}
}
