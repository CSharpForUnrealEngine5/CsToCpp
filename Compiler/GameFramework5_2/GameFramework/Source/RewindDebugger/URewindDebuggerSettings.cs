namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Implements the settings for the Rewind Debugger.</summary>
[CppInclude("RewindDebuggerSettings.h")]
public partial class URewindDebuggerSettings : UDeveloperSettings {
	public static UClass StaticClass() {return default;}
	///<summary>Rewind Debugger Playback Camera Mode</summary>
	public ERewindDebuggerCameraMode CameraMode;
	///<summary>If enabled, start recording information at the start of PIE</summary>
	public bool bShouldAutoRecordOnPIE;
	///<summary>If enabled, show empty tracks on Rewind Debugger Timeline</summary>
	public bool bShowEmptyObjectTracks;
}
