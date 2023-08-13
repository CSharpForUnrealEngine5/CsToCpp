namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Holds a request made via websocket to automatically destroy a transient preset when the calling client disconnects.</summary>
[CppInclude("RemoteControlRequest.h")]
public partial struct FRCWebSocketTransientPresetAutoDestroyBody {
	public string PresetName;
}
