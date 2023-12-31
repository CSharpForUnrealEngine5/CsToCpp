namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DirectLinkExtensionSettings.h")]
public partial class UDirectLinkExtensionSettings : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Whether or not to attempt reconnecting lost connection.</summary>
	public bool bAutoReconnect;
	///<summary>Time in seconds to wait between reconnection attempts.</summary>
	public float ReconnectionDelayInSeconds;
}
