#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Lightweight representation of a player while connected to the game through the lobby</summary>
[CppInclude("LobbyBeaconPlayerState.h")]
public partial class ALobbyBeaconPlayerState : AInfo {
	public static UClass StaticClass() {return default;}
	///<summary>Visible friendly player name</summary>
	public string DisplayName;
	///<summary>Player unique id</summary>
	public FUniqueNetIdRepl UniqueId;
	///<summary>Party owner id</summary>
	public FUniqueNetIdRepl PartyOwnerUniqueId;
	///<summary>Is the player in the lobby or game</summary>
	public bool bInLobby;
	///<summary>Reference to the beacon actor related to this player</summary>
	public AOnlineBeaconClient ClientActor;
	///<summary>Unique Id has replicated</summary>
	public  void OnRep_UniqueId() {}
	///<summary>Party owner has changed</summary>
	public  void OnRep_PartyOwner() {}
	///<summary>Player has joined or left the lobby</summary>
	public  void OnRep_InLobby() {}
}
