#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A PlayerState is created for every player on a server (or in a standalone game).</summary>
[CppInclude("GameFramework/PlayerState.h")]
public partial class APlayerState : AInfo {
	///<summary>Score</summary>
	public float Score;
	///<summary>PlayerId</summary>
	public int PlayerId;
	///<summary>Replicated compressed ping for this player (holds ping in msec divided by 4)</summary>
	public byte CompressedPing;
	///<summary>Whether or not this player&#39;s replicated CompressedPing value is updated automatically.</summary>
	public bool bShouldUpdateReplicatedPing;
	///<summary>bIsSpectator</summary>
	public bool bIsSpectator;
	///<summary>bOnlySpectator</summary>
	public bool bOnlySpectator;
	///<summary>bIsABot</summary>
	public bool bIsABot;
	///<summary>bIsInactive</summary>
	public bool bIsInactive;
	///<summary>bFromPreviousLevel</summary>
	public bool bFromPreviousLevel;
	///<summary>StartTime</summary>
	public int StartTime;
	///<summary>This is used for sending game agnostic messages that can be localized</summary>
	public UClass EngineMessageClass;
	///<summary>Used to match up InactivePlayerState with rejoining playercontroller.</summary>
	public string SavedNetworkAddress;
	///<summary>UniqueId</summary>
	public FUniqueNetIdRepl UniqueId;
	///<summary>Broadcast whenever this player&#39;s possessed pawn is set</summary>
	public FOnPlayerStatePawnSet OnPawnSet;
	///<summary>The pawn that is controlled by by this player state.</summary>
	public APawn PawnPrivate;
	///<summary>OnPawnPrivateDestroyed</summary>
	public  void OnPawnPrivateDestroyed(AActor InActor) {}
	///<summary>Player name, or blank if none.</summary>
	public string PlayerNamePrivate;
	///<summary>Replication Notification Callbacks</summary>
	public  void OnRep_Score() {}
	///<summary>OnRep_PlayerName</summary>
	public  void OnRep_PlayerName() {}
	///<summary>OnRep_bIsInactive</summary>
	public  void OnRep_bIsInactive() {}
	///<summary>OnRep_PlayerId</summary>
	public  void OnRep_PlayerId() {}
	///<summary>OnRep_UniqueId</summary>
	public  void OnRep_UniqueId() {}
	///<summary>Return the pawn controlled by this Player State.</summary>
	public  APawn GetPawn() { return default; }
	///<summary>Return the player controller that created this player state, or null for remote clients</summary>
	public  APlayerController GetPlayerController() { return default; }
	///<summary>returns current player name</summary>
	public  string GetPlayerName() { return default; }
	///<summary>* Can be implemented in Blueprint Child to move more properties from old to new PlayerState when reconnecting</summary>
	public  void ReceiveOverrideWith(APlayerState OldPlayerState) {}
	///<summary>* Can be implemented in Blueprint Child to move more properties from old to new PlayerState when traveling to a new level</summary>
	public  void ReceiveCopyProperties(APlayerState NewPlayerState) {}
	///<summary>Gets the literal value of Score.</summary>
	public  float GetScore() { return default; }
	///<summary>Gets the literal value of PlayerId.</summary>
	public  int GetPlayerId() { return default; }
	///<summary>Gets the literal value of the compressed Ping value (Ping = PingInMS / 4).</summary>
	public  byte GetCompressedPing() { return default; }
	///<summary>Returns the ping (in milliseconds)</summary>
	public  float GetPingInMilliseconds() { return default; }
	///<summary>Gets the literal value of bIsSpectator.</summary>
	public  bool IsSpectator() { return default; }
	///<summary>Gets the literal value of bOnlySpectator.</summary>
	public  bool IsOnlyASpectator() { return default; }
	///<summary>Gets the literal value of bIsABot.</summary>
	public  bool IsABot() { return default; }
	///<summary>Gets the online unique id for a player. If a player is logged in this will be consistent across all clients and servers.</summary>
	public  FUniqueNetIdRepl BP_GetUniqueId() { return default; }
}
