namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A beacon client used for making reservations with an existing game session</summary>
[CppInclude("TestBeaconClient.h")]
public partial class ATestBeaconClient : AOnlineBeaconClient {
	public static UClass StaticClass() {return default;}
	///<summary>Send a ping RPC to the client</summary>
	public virtual void ClientPing() {}
	///<summary>Send a pong RPC to the host</summary>
	public virtual void ServerPong() {}
}
