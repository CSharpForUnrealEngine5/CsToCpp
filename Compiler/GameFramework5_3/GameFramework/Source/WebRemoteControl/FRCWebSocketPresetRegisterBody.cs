namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Holds a request made via websocket to register for events about a given preset.</summary>
[CppInclude("RemoteControlRequest.h")]
public partial struct FRCWebSocketPresetRegisterBody {
	public string PresetName;
	public bool IgnoreRemoteChanges;
}
