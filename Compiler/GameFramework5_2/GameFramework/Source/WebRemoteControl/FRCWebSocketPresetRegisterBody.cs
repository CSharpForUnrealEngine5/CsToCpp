#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RemoteControlRequest.h")]
///<summary>Holds a request made via websocket to register for events about a given preset.</summary>
public partial struct FRCWebSocketPresetRegisterBody {
// RCWebSocketPresetRegisterBody
	public string PresetName;
	public bool IgnoreRemoteChanges;
}
