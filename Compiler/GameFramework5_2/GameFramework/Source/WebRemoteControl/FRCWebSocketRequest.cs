namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Holds a request made for web socket.</summary>
[CppInclude("RemoteControlRequest.h")]
public partial struct FRCWebSocketRequest {
	public string MessageName;
	public int Id;
	public string ForwardedFor;
}
