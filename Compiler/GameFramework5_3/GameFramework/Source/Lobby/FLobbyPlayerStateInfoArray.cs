namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Struct for fast TArray replication of lobby player state</summary>
[CppInclude("LobbyBeaconState.h")]
public partial struct FLobbyPlayerStateInfoArray {
	public TArray<FLobbyPlayerStateActorInfo> Players;
	public ALobbyBeaconState ParentState;
}
