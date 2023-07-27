#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("OnlineBeaconClient.h")]
///<summary>Base class for any unique beacon connectivity, paired with an AOnlineBeaconHostObject implementation</summary>
public partial class AOnlineBeaconClient : AOnlineBeacon {
// OnlineBeaconClient
	public AOnlineBeaconHostObject BeaconOwner;
	public UNetConnection BeaconConnection;
	public EBeaconConnectionState ConnectionState;
	public  void ClientOnConnected() {}
}
