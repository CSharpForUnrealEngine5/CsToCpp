#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GameFramework/PlayerState.h")]
///<summary>A PlayerState is created for every player on a server (or in a standalone game).</summary>
public partial class APlayerState : AInfo {
// PlayerState
	public float Score;
	public int PlayerId;
	public byte CompressedPing;
	public bool bShouldUpdateReplicatedPing;
	public bool bIsSpectator;
	public bool bOnlySpectator;
	public bool bIsABot;
	public bool bIsInactive;
	public bool bFromPreviousLevel;
	public int StartTime;
	public UClass EngineMessageClass;
	public string SavedNetworkAddress;
	public FUniqueNetIdRepl UniqueId;
	public FOnPlayerStatePawnSet OnPawnSet;
	public APawn PawnPrivate;
	public void OnPawnPrivateDestroyed(UObject InActor) {}
	public string PlayerNamePrivate;
	public void OnRep_Score() {}
	public void OnRep_PlayerName() {}
	public void OnRep_bIsInactive() {}
	public void OnRep_PlayerId() {}
	public void OnRep_UniqueId() {}
	public UObject GetPawn() { return default; }
	public UObject GetPlayerController() { return default; }
	public string GetPlayerName() { return default; }
	public void ReceiveOverrideWith(UObject OldPlayerState) {}
	public void ReceiveCopyProperties(UObject NewPlayerState) {}
	public float GetScore() { return default; }
	public int GetPlayerId() { return default; }
	public byte GetCompressedPing() { return default; }
	public float GetPingInMilliseconds() { return default; }
	public bool IsSpectator() { return default; }
	public bool IsOnlyASpectator() { return default; }
	public bool IsABot() { return default; }
	public FUniqueNetIdRepl BP_GetUniqueId() { return default; }
}
