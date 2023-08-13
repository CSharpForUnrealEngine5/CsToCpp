namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Holds a request that wraps multiple requests..</summary>
[CppInclude("RemoteControlRequest.h")]
public partial struct FRCBatchRequest {
	public TArray<FRCRequestWrapper> Requests;
}
