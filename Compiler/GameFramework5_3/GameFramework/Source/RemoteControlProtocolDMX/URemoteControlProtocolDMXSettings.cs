namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>DMX Remote Control Settings</summary>
[CppInclude("RemoteControlProtocolDMXSettings.h")]
public partial class URemoteControlProtocolDMXSettings : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>GetOrCreateDefaultInputPortId</summary>
	public FGuid GetOrCreateDefaultInputPortId() { return default; }
	///<summary>DMX Default Device</summary>
	public FGuid DefaultInputPortId;
}
