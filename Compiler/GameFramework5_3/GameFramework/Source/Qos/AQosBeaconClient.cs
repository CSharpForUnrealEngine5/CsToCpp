namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A beacon client used for quality timings to a specified session</summary>
[CppInclude("QosBeaconClient.h")]
public partial class AQosBeaconClient : AOnlineBeaconClient {
	public static UClass StaticClass() {return default;}
	///<summary>Contact the server with a Qos request and begin timing</summary>
	public virtual void ServerQosRequest(string InSessionId) {}
	///<summary>Response from the host session after making a Qos request</summary>
	public virtual void ClientQosResponse(EQosResponseType Response) {}
}
