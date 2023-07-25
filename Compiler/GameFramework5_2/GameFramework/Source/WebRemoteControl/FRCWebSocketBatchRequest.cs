#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RemoteControlRequest.h")]
///<summary>Holds a request that wraps multiple requests..</summary>
public partial struct FRCWebSocketBatchRequest {
// RCWebSocketBatchRequest
	public TArray<FRCWebSocketRequest> Requests;
}
