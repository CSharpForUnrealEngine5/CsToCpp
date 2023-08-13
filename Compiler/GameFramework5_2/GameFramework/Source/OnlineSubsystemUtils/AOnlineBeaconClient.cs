namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Base class for any unique beacon connectivity, paired with an AOnlineBeaconHostObject implementation</summary>
[CppInclude("OnlineBeaconClient.h")]
public partial class AOnlineBeaconClient : AOnlineBeacon {
	public static UClass StaticClass() {return default;}
	///<summary>Owning beacon host of this beacon actor (server only)</summary>
	public AOnlineBeaconHostObject BeaconOwner;
	///<summary>Network connection associated with this beacon client instance</summary>
	public UNetConnection BeaconConnection;
	///<summary>State of the connection</summary>
	public EBeaconConnectionState ConnectionState;
	///<summary>Called on the server side to open up the actor channel that will allow RPCs to occur</summary>
	public void ClientOnConnected() {}
}
