#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RemoteControlRequest.h")]
///<summary>Holds a request made via websocket to automatically destroy a transient preset when the calling client disconnects.</summary>
public partial struct FRCWebSocketTransientPresetAutoDestroyBody {
// RCWebSocketTransientPresetAutoDestroyBody
	public string PresetName;
}
