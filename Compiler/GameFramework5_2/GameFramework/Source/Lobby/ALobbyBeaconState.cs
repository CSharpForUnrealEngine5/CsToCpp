#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Shared state of the game from the lobby perspective</summary>
[CppInclude("LobbyBeaconState.h")]
public partial class ALobbyBeaconState : AInfo {
	///<summary>Total number of players allowed in the lobby</summary>
	public int MaxPlayers;
	///<summary>Class to use for lobby beacon player states</summary>
	public UClass LobbyBeaconPlayerStateClass;
	///<summary>Has the lobby already been started</summary>
	public bool bLobbyStarted;
	///<summary>Amount of time waiting for other players before starting the lobby</summary>
	public float WaitForPlayersTimeRemaining;
	///<summary>Array of players currently in the game, lobby or otherwise</summary>
	public FLobbyPlayerStateInfoArray Players;
	///<summary>Handle the lobby starting</summary>
	public  void OnRep_LobbyStarted() {}
	///<summary>Handle notification of time left to wait for lobby to start</summary>
	public  void OnRep_WaitForPlayersTimeRemaining() {}
}
