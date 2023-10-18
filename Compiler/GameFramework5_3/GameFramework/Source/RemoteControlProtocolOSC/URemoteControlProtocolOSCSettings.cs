namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>OSC Remote Control settings</summary>
[CppInclude("RemoteControlProtocolOSCSettings.h")]
public partial class URemoteControlProtocolOSCSettings : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>OSC server pair of server ip and server port</summary>
	public TArray<FRemoteControlOSCServerSettings> ServersSettings;
}
