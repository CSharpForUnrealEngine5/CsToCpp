#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("LobbyBeaconHost.h")]
///<summary>Host object for maintaining a lobby before players actually join a server ready to receive them</summary>
public partial class ALobbyBeaconHost : AOnlineBeaconHostObject {
// LobbyBeaconHost
	public TSoftObjectPtr<UClass> LobbyStateClass;
	public ALobbyBeaconState LobbyState;
}
