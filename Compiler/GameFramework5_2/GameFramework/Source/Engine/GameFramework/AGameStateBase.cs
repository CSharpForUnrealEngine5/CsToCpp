namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>GameStateBase is a class that manages the game&#39;s global state, and is spawned by GameModeBase.</summary>
[CppInclude("GameFramework/GameStateBase.h")]
public partial class AGameStateBase : AInfo {
	public static UClass StaticClass() {return default;}
	///<summary>Class of the server&#39;s game mode, assigned by GameModeBase.</summary>
	public UClass GameModeClass;
	///<summary>Instance of the current game mode, exists only on the server. For non-authority clients, this will be NULL.</summary>
	public AGameModeBase AuthorityGameMode;
	///<summary>Class used by spectators, assigned by GameModeBase.</summary>
	public UClass SpectatorClass;
	///<summary>Array of all PlayerStates, maintained on both server and clients (PlayerStates are always relevant)</summary>
	public TArray<APlayerState> PlayerArray;
	///<summary>Returns the simulated TimeSeconds on the server, will be synchronized on client and server</summary>
	public virtual double GetServerWorldTimeSeconds() { return default; }
	///<summary>Returns true if the world has started play (called BeginPlay on actors)</summary>
	public virtual bool HasBegunPlay() { return default; }
	///<summary>Returns true if the world has started match (called MatchStarted callbacks)</summary>
	public virtual bool HasMatchStarted() { return default; }
	///<summary>Returns true if the match can be considered ended. Defaults to false.</summary>
	public virtual bool HasMatchEnded() { return default; }
	///<summary>Returns the time that should be used as when a player started</summary>
	public virtual float GetPlayerStartTime(AController Controller) { return default; }
	///<summary>Returns how much time needs to be spent before a player can respawn</summary>
	public virtual float GetPlayerRespawnDelay(AController Controller) { return default; }
	///<summary>GameModeBase class notification callback.</summary>
	public virtual void OnRep_GameModeClass() {}
	///<summary>Callback when we receive the spectator class</summary>
	public virtual void OnRep_SpectatorClass() {}
	///<summary>By default calls BeginPlay and StartMatch</summary>
	public virtual void OnRep_ReplicatedHasBegunPlay() {}
	///<summary>Replicated when GameModeBase-&gt;StartPlay has been called so the client will also start play</summary>
	public bool bReplicatedHasBegunPlay;
	///<summary>OnRep_ReplicatedWorldTimeSeconds</summary>
	public virtual void OnRep_ReplicatedWorldTimeSeconds() {}
	///<summary>Allows clients to calculate ServerWorldTimeSecondsDelta</summary>
	public virtual void OnRep_ReplicatedWorldTimeSecondsDouble() {}
	///<summary>ReplicatedWorldTimeSeconds</summary>
	public float ReplicatedWorldTimeSeconds;
	///<summary>ReplicatedWorldTimeSecondsDouble</summary>
	public double ReplicatedWorldTimeSecondsDouble;
	///<summary>The difference from the local world&#39;s TimeSeconds and the server world&#39;s TimeSeconds.</summary>
	public float ServerWorldTimeSecondsDelta;
	///<summary>Frequency that the server updates the replicated TimeSeconds from the world. Set to zero to disable periodic updates.</summary>
	public float ServerWorldTimeSecondsUpdateFrequency;
}
