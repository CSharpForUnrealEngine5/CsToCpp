#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>OSC Remote Control settings</summary>
[CppInclude("RemoteControlProtocolOSCSettings.h")]
public partial class URemoteControlProtocolOSCSettings : UObject {
	///<summary>OSC server pair of server ip and server port</summary>
	public TArray<FRemoteControlOSCServerSettings> ServersSettings;
}
