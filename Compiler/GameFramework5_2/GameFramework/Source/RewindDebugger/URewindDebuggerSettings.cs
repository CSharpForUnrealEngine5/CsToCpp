#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Implements the settings for the Rewind Debugger.</summary>
[CppInclude("RewindDebuggerSettings.h")]
public partial class URewindDebuggerSettings : UDeveloperSettings {
	///<summary>Rewind Debugger Playback Camera Mode</summary>
	public ERewindDebuggerCameraMode CameraMode;
	///<summary>If enabled, start recording information at the start of PIE</summary>
	public bool bShouldAutoRecordOnPIE;
	///<summary>If enabled, show empty tracks on Rewind Debugger Timeline</summary>
	public bool bShowEmptyObjectTracks;
}
