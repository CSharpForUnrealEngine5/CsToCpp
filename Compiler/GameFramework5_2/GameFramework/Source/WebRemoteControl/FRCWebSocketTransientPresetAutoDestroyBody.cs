#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Holds a request made via websocket to automatically destroy a transient preset when the calling client disconnects.</summary>
[CppInclude("RemoteControlRequest.h")]
public partial struct FRCWebSocketTransientPresetAutoDestroyBody {
	public string PresetName;
}
