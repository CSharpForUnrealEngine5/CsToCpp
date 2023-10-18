namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>MIDI Remote Control Settings</summary>
[CppInclude("RemoteControlProtocolMIDISettings.h")]
public partial class URemoteControlProtocolMIDISettings : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Midi Default Device</summary>
	public FRemoteControlMIDIDevice DefaultDevice;
}
