#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A beacon client used for making reservations with an existing game session</summary>
[CppInclude("TestBeaconClient.h")]
public partial class ATestBeaconClient : AOnlineBeaconClient {
	///<summary>Send a ping RPC to the client</summary>
	public  void ClientPing() {}
	///<summary>Send a pong RPC to the host</summary>
	public  void ServerPong() {}
}
