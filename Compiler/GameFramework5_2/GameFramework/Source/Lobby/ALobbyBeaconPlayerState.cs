#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("LobbyBeaconPlayerState.h")]
///<summary>Lightweight representation of a player while connected to the game through the lobby</summary>
public partial class ALobbyBeaconPlayerState : AInfo {
// LobbyBeaconPlayerState
	public string DisplayName;
	public FUniqueNetIdRepl UniqueId;
	public FUniqueNetIdRepl PartyOwnerUniqueId;
	public bool bInLobby;
	public AOnlineBeaconClient ClientActor;
	public void OnRep_UniqueId() {}
	public void OnRep_PartyOwner() {}
	public void OnRep_InLobby() {}
}
