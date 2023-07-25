#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("QosBeaconClient.h")]
///<summary>A beacon client used for quality timings to a specified session</summary>
public partial class AQosBeaconClient : AOnlineBeaconClient {
// QosBeaconClient
	public void ServerQosRequest(string InSessionId) {}
	public void ClientQosResponse(EQosResponseType Response) {}
}
