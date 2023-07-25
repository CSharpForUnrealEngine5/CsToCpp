#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RemoteControlRequest.h")]
///<summary>Holds a request made for web socket.</summary>
public partial struct FRCWebSocketRequest {
// RCWebSocketRequest
	public string MessageName;
	public int Id;
	public string ForwardedFor;
}
