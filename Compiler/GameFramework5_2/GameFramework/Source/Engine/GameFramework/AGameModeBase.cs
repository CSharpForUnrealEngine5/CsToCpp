#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GameFramework/GameModeBase.h")]
///<summary>The GameModeBase defines the game being played. It governs the game rules, scoring, what actors</summary>
public partial class AGameModeBase : AInfo {
// GameModeBase
	public string OptionsString;
	public UClass GetDefaultPawnClassForController(UObject InController) { return default; }
	public UClass GameSessionClass;
	public UClass GameStateClass;
	public UClass PlayerControllerClass;
	public UClass PlayerStateClass;
	public UClass HUDClass;
	public UClass DefaultPawnClass;
	public UClass SpectatorClass;
	public UClass ReplaySpectatorPlayerControllerClass;
	public UClass ServerStatReplicatorClass;
	public AGameSession GameSession;
	public AGameStateBase GameState;
	public AServerStatReplicator ServerStatReplicator;
	public int GetNumPlayers() { return default; }
	public int GetNumSpectators() { return default; }
	public void StartPlay() {}
	public bool HasMatchStarted() { return default; }
	public bool HasMatchEnded() { return default; }
	public bool ShouldReset(UObject ActorToReset) { return default; }
	public void ResetLevel() {}
	public void ReturnToMainMenuHost() {}
	public void K2_PostLogin(UObject NewPlayer) {}
	public void K2_OnLogout(UObject ExitingController) {}
	public void HandleStartingNewPlayer(UObject NewPlayer) {}
	public bool MustSpectate(UObject NewPlayerController) { return default; }
	public bool CanSpectate(UObject Viewer,UObject ViewTarget) { return default; }
	public string DefaultPlayerName;
	public void ChangeName(UObject Controller,string NewName,bool bNameChange) {}
	public void K2_OnChangeName(UObject Other,string NewName,bool bNameChange) {}
	public UObject ChoosePlayerStart(UObject Player) { return default; }
	public UObject FindPlayerStart(UObject Player,string IncomingName) { return default; }
	public UObject K2_FindPlayerStart(UObject Player,string IncomingName/*=TEXT("")*/) { return default; }
	public bool PlayerCanRestart(UObject Player) { return default; }
	public void RestartPlayer(UObject NewPlayer) {}
	public void RestartPlayerAtPlayerStart(UObject NewPlayer,UObject StartSpot) {}
	public void RestartPlayerAtTransform(UObject NewPlayer,FTransform SpawnTransform) {}
	public UObject SpawnDefaultPawnFor(UObject NewPlayer,UObject StartSpot) { return default; }
	public UObject SpawnDefaultPawnAtTransform(UObject NewPlayer,FTransform SpawnTransform) { return default; }
	public void InitStartSpot(UObject StartSpot,UObject NewPlayer) {}
	public void K2_OnRestartPlayer(UObject NewPlayer) {}
	public void InitializeHUDForPlayer(UObject NewPlayer) {}
	public void K2_OnSwapPlayerControllers(UObject OldPC,UObject NewPC) {}
	public bool bUseSeamlessTravel;
	public bool bStartPlayersAsSpectators;
	public bool bPauseable;
}
