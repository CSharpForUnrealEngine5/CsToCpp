#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A beacon client used for quality timings to a specified session</summary>
[CppInclude("QosBeaconClient.h")]
public partial class AQosBeaconClient : AOnlineBeaconClient {
	///<summary>Contact the server with a Qos request and begin timing</summary>
	public  void ServerQosRequest(string InSessionId) {}
	///<summary>Response from the host session after making a Qos request</summary>
	public  void ClientQosResponse(EQosResponseType Response) {}
}
