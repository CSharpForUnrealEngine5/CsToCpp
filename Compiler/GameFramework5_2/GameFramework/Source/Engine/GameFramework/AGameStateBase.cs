#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GameFramework/GameStateBase.h")]
///<summary>GameStateBase is a class that manages the game's global state, and is spawned by GameModeBase.</summary>
public partial class AGameStateBase : AInfo {
// GameStateBase
	public UClass GameModeClass;
	public AGameModeBase AuthorityGameMode;
	public UClass SpectatorClass;
	public TArray<APlayerState> PlayerArray;
	public double GetServerWorldTimeSeconds() { return default; }
	public bool HasBegunPlay() { return default; }
	public bool HasMatchStarted() { return default; }
	public bool HasMatchEnded() { return default; }
	public float GetPlayerStartTime(UObject Controller) { return default; }
	public float GetPlayerRespawnDelay(UObject Controller) { return default; }
	public void OnRep_GameModeClass() {}
	public void OnRep_SpectatorClass() {}
	public void OnRep_ReplicatedHasBegunPlay() {}
	public bool bReplicatedHasBegunPlay;
	public void OnRep_ReplicatedWorldTimeSeconds() {}
	public void OnRep_ReplicatedWorldTimeSecondsDouble() {}
	public float ReplicatedWorldTimeSeconds;
	public double ReplicatedWorldTimeSecondsDouble;
	public float ServerWorldTimeSecondsDelta;
	public float ServerWorldTimeSecondsUpdateFrequency;
}
