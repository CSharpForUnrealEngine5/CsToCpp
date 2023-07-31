#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>DMX Remote Control Settings</summary>
[CppInclude("RemoteControlProtocolDMXSettings.h")]
public partial class URemoteControlProtocolDMXSettings : UObject {
	///<summary>GetOrCreateDefaultInputPortId</summary>
	public  FGuid GetOrCreateDefaultInputPortId() { return default; }
	///<summary>DMX Default Device</summary>
	public FGuid DefaultInputPortId;
}
