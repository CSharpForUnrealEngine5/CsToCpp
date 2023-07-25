#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("LobbyBeaconState.h")]
///<summary>Struct for fast TArray replication of lobby player state</summary>
public partial struct FLobbyPlayerStateInfoArray {
// LobbyPlayerStateInfoArray
	public TArray<FLobbyPlayerStateActorInfo> Players;
	public ALobbyBeaconState ParentState;
}
