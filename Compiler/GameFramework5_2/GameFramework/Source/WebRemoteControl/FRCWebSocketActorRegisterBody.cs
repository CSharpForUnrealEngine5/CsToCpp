#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RemoteControlRequest.h")]
///<summary>Holds a request made via websocket to register for spawn/destroy events about a given actor type.</summary>
public partial struct FRCWebSocketActorRegisterBody {
// RCWebSocketActorRegisterBody
	public string ClassName;
}
