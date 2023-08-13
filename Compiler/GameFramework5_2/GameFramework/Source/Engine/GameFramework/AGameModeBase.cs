namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>The GameModeBase defines the game being played. It governs the game rules, scoring, what actors</summary>
[CppInclude("GameFramework/GameModeBase.h")]
public partial class AGameModeBase : AInfo {
	public static UClass StaticClass() {return default;}
	///<summary>Save options string and parse it when needed</summary>
	public string OptionsString;
	///<summary>Returns default pawn class for given controller</summary>
	public UClass GetDefaultPawnClassForController(AController InController) { return default; }
	///<summary>Class of GameSession, which handles login approval and online game interface</summary>
	public UClass GameSessionClass;
	///<summary>Class of GameState associated with this GameMode.</summary>
	public UClass GameStateClass;
	///<summary>The class of PlayerController to spawn for players logging in.</summary>
	public UClass PlayerControllerClass;
	///<summary>A PlayerState of this class will be associated with every player to replicate relevant player information to all clients.</summary>
	public UClass PlayerStateClass;
	///<summary>HUD class this game uses.</summary>
	public UClass HUDClass;
	///<summary>The default pawn class used by players.</summary>
	public UClass DefaultPawnClass;
	///<summary>The pawn class used by the PlayerController for players when spectating.</summary>
	public UClass SpectatorClass;
	///<summary>The PlayerController class used when spectating a network replay.</summary>
	public UClass ReplaySpectatorPlayerControllerClass;
	///<summary>ServerStatReplicatorClass</summary>
	public UClass ServerStatReplicatorClass;
	///<summary>Game Session handles login approval, arbitration, online game interface</summary>
	public AGameSession GameSession;
	///<summary>GameState is used to replicate game state relevant properties to all clients.</summary>
	public AGameStateBase GameState;
	///<summary>ServerStatReplicator</summary>
	public AServerStatReplicator ServerStatReplicator;
	///<summary>Returns number of active human players, excluding spectators</summary>
	public virtual int GetNumPlayers() { return default; }
	///<summary>Returns number of human players currently spectating</summary>
	public virtual int GetNumSpectators() { return default; }
	///<summary>Transitions to calls BeginPlay on actors.</summary>
	public virtual void StartPlay() {}
	///<summary>Returns true if the match start callbacks have been called</summary>
	public virtual bool HasMatchStarted() { return default; }
	///<summary>Returns true if the match can be considered ended</summary>
	public virtual bool HasMatchEnded() { return default; }
	///<summary>Overridable function to determine whether an Actor should have Reset called when the game has Reset called on it.</summary>
	public bool ShouldReset(AActor ActorToReset) { return default; }
	///<summary>Overridable function called when resetting level. This is used to reset the game state while staying in the same map</summary>
	public virtual void ResetLevel() {}
	///<summary>Return to main menu, and disconnect any players</summary>
	public virtual void ReturnToMainMenuHost() {}
	///<summary>Notification that a player has successfully logged in, and has been given a player controller</summary>
	public void K2_PostLogin(APlayerController NewPlayer) {}
	///<summary>Implementable event when a Controller with a PlayerState leaves the game.</summary>
	public void K2_OnLogout(AController ExitingController) {}
	///<summary>Signals that a player is ready to enter the game, which may start it up</summary>
	public void HandleStartingNewPlayer(APlayerController NewPlayer) {}
	///<summary>Returns true if NewPlayerController may only join the server as a spectator.</summary>
	public bool MustSpectate(APlayerController NewPlayerController) { return default; }
	///<summary>Return whether Viewer is allowed to spectate from the point of view of ViewTarget.</summary>
	public bool CanSpectate(APlayerController Viewer,APlayerState ViewTarget) { return default; }
	///<summary>The default player name assigned to players that join with no name specified.</summary>
	public FText DefaultPlayerName;
	///<summary>Sets the name for a controller</summary>
	public virtual void ChangeName(AController Controller,string NewName,bool bNameChange) {}
	///<summary>Overridable event for GameMode blueprint to respond to a change name call</summary>
	public void K2_OnChangeName(AController Other,string NewName,bool bNameChange) {}
	///<summary>Return the &#39;best&#39; player start for this player to spawn from</summary>
	public AActor ChoosePlayerStart(AController Player) { return default; }
	///<summary>Return the specific player start actor that should be used for the next spawn</summary>
	public AActor FindPlayerStart(AController Player,string IncomingName) { return default; }
	///<summary>Return the specific player start actor that should be used for the next spawn</summary>
	public AActor K2_FindPlayerStart(AController Player,string IncomingName/*=TEXT("")*/) { return default; }
	///<summary>Returns true if it&#39;s valid to call RestartPlayer. By default will call Player-&gt;CanRestartPlayer</summary>
	public bool PlayerCanRestart(APlayerController Player) { return default; }
	///<summary>Tries to spawn the player&#39;s pawn, at the location returned by FindPlayerStart</summary>
	public virtual void RestartPlayer(AController NewPlayer) {}
	///<summary>Tries to spawn the player&#39;s pawn at the specified actor&#39;s location</summary>
	public virtual void RestartPlayerAtPlayerStart(AController NewPlayer,AActor StartSpot) {}
	///<summary>Tries to spawn the player&#39;s pawn at a specific location</summary>
	public virtual void RestartPlayerAtTransform(AController NewPlayer,FTransform SpawnTransform) {}
	///<summary>Called during RestartPlayer to actually spawn the player&#39;s pawn, when using a start spot</summary>
	public APawn SpawnDefaultPawnFor(AController NewPlayer,AActor StartSpot) { return default; }
	///<summary>Called during RestartPlayer to actually spawn the player&#39;s pawn, when using a transform</summary>
	public APawn SpawnDefaultPawnAtTransform(AController NewPlayer,FTransform SpawnTransform) { return default; }
	///<summary>Called from RestartPlayerAtPlayerStart, can be used to initialize the start spawn actor</summary>
	public void InitStartSpot(AActor StartSpot,AController NewPlayer) {}
	///<summary>Implementable event called at the end of RestartPlayer</summary>
	public void K2_OnRestartPlayer(AController NewPlayer) {}
	///<summary>Initialize the AHUD object for a player. Games can override this to do something different</summary>
	public void InitializeHUDForPlayer(APlayerController NewPlayer) {}
	///<summary>Called when a PlayerController is swapped to a new one during seamless travel</summary>
	public void K2_OnSwapPlayerControllers(APlayerController OldPC,APlayerController NewPC) {}
	///<summary>Whether the game perform map travels using SeamlessTravel() which loads in the background and doesn&#39;t disconnect clients</summary>
	public bool bUseSeamlessTravel;
	///<summary>Whether players should immediately spawn when logging in, or stay as spectators until they manually spawn</summary>
	public bool bStartPlayersAsSpectators;
	///<summary>Whether the game is pauseable.</summary>
	public bool bPauseable;
}
