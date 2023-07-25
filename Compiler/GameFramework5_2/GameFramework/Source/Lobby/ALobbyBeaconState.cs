#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("LobbyBeaconState.h")]
///<summary>Shared state of the game from the lobby perspective</summary>
public partial class ALobbyBeaconState : AInfo {
// LobbyBeaconState
	public int MaxPlayers;
	public UClass LobbyBeaconPlayerStateClass;
	public bool bLobbyStarted;
	public float WaitForPlayersTimeRemaining;
	public FLobbyPlayerStateInfoArray Players;
	public void OnRep_LobbyStarted() {}
	public void OnRep_WaitForPlayersTimeRemaining() {}
}
