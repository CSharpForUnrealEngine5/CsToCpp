namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Host object for maintaining a lobby before players actually join a server ready to receive them</summary>
[CppInclude("LobbyBeaconHost.h")]
public partial class ALobbyBeaconHost : AOnlineBeaconHostObject {
	public static UClass StaticClass() {return default;}
	///<summary>Class to use for the lobby beacon state</summary>
	public TSoftObjectPtr<UClass> LobbyStateClass;
	///<summary>Actor representing the state of the lobby (similar to AGameState)</summary>
	public ALobbyBeaconState LobbyState;
}
