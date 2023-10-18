namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A beacon client used for quality timings to a specified session</summary>
[CppInclude("LobbyBeaconClient.h")]
public partial class ALobbyBeaconClient : AOnlineBeaconClient {
	public static UClass StaticClass() {return default;}
	///<summary>Client view of the lobby state</summary>
	public ALobbyBeaconState LobbyState;
	///<summary>Player state associated with this beacon (@todo not splitscreen safe)</summary>
	public ALobbyBeaconPlayerState PlayerState;
	///<summary>Tell the client to join the game</summary>
	public virtual void ClientJoinGame() {}
	///<summary>Send updated session settings to client</summary>
	public void ClientSetInviteFlags(FJoinabilitySettings Settings) {}
	///<summary>Run a cheat command on the server</summary>
	public void ServerCheat(string Msg) {}
	///<summary>True once the server has acknowledged our join intent</summary>
	public ELobbyBeaconJoinState LobbyJoinServerState;
	///<summary>Attempt to login a single local player with the lobby beacon</summary>
	public virtual void ServerLoginPlayer(string InSessionId,FUniqueNetIdRepl InUniqueId,string UrlString) {}
	///<summary>Make a graceful disconnect with the server</summary>
	public virtual void ServerDisconnectFromLobby() {}
	///<summary>Make a graceful request to actually join the server</summary>
	public virtual void ServerNotifyJoiningServer() {}
	///<summary>ClientAckJoiningServer</summary>
	public virtual void ClientAckJoiningServer() {}
	///<summary>Make a request to kick a given player</summary>
	public virtual void ServerKickPlayer(FUniqueNetIdRepl PlayerToKick,FText Reason) {}
	///<summary>Make a request to set the party owner for the given player</summary>
	public virtual void ServerSetPartyOwner(FUniqueNetIdRepl InUniqueId,FUniqueNetIdRepl InPartyOwnerId) {}
	///<summary>Client notification result for a single login attempt</summary>
	public void ClientLoginComplete(FUniqueNetIdRepl InUniqueId,bool bWasSuccessful) {}
	///<summary>This was client was kicked by the server</summary>
	public void ClientWasKicked(FText KickReason) {}
	///<summary>Client notification that another player has joined the lobby</summary>
	public virtual void ClientPlayerJoined(FText NewPlayerName,FUniqueNetIdRepl InUniqueId) {}
	///<summary>Client notification that another player has left the lobby</summary>
	public virtual void ClientPlayerLeft(FUniqueNetIdRepl InUniqueId) {}
}
