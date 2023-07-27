#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GameFramework/GameModeBase.h")]
///<summary>The GameModeBase defines the game being played. It governs the game rules, scoring, what actors</summary>
public partial class AGameModeBase : AInfo {
// GameModeBase
	public string OptionsString;
	public  UClass GetDefaultPawnClassForController(AController InController) { return default; }
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
	public  int GetNumPlayers() { return default; }
	public  int GetNumSpectators() { return default; }
	public  void StartPlay() {}
	public  bool HasMatchStarted() { return default; }
	public  bool HasMatchEnded() { return default; }
	public  bool ShouldReset(AActor ActorToReset) { return default; }
	public  void ResetLevel() {}
	public  void ReturnToMainMenuHost() {}
	public  void K2_PostLogin(APlayerController NewPlayer) {}
	public  void K2_OnLogout(AController ExitingController) {}
	public  void HandleStartingNewPlayer(APlayerController NewPlayer) {}
	public  bool MustSpectate(APlayerController NewPlayerController) { return default; }
	public  bool CanSpectate(APlayerController Viewer,APlayerState ViewTarget) { return default; }
	public string DefaultPlayerName;
	public  void ChangeName(AController Controller,string NewName,bool bNameChange) {}
	public  void K2_OnChangeName(AController Other,string NewName,bool bNameChange) {}
	public  AActor ChoosePlayerStart(AController Player) { return default; }
	public  AActor FindPlayerStart(AController Player,string IncomingName) { return default; }
	public  AActor K2_FindPlayerStart(AController Player,string IncomingName/*=TEXT("")*/) { return default; }
	public  bool PlayerCanRestart(APlayerController Player) { return default; }
	public  void RestartPlayer(AController NewPlayer) {}
	public  void RestartPlayerAtPlayerStart(AController NewPlayer,AActor StartSpot) {}
	public  void RestartPlayerAtTransform(AController NewPlayer,FTransform SpawnTransform) {}
	public  APawn SpawnDefaultPawnFor(AController NewPlayer,AActor StartSpot) { return default; }
	public  APawn SpawnDefaultPawnAtTransform(AController NewPlayer,FTransform SpawnTransform) { return default; }
	public  void InitStartSpot(AActor StartSpot,AController NewPlayer) {}
	public  void K2_OnRestartPlayer(AController NewPlayer) {}
	public  void InitializeHUDForPlayer(APlayerController NewPlayer) {}
	public  void K2_OnSwapPlayerControllers(APlayerController OldPC,APlayerController NewPC) {}
	public bool bUseSeamlessTravel;
	public bool bStartPlayersAsSpectators;
	public bool bPauseable;
}
