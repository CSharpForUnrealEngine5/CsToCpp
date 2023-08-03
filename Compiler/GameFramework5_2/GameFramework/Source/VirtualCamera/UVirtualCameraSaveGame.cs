#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("VirtualCameraSaveGame.h")]
public partial class UVirtualCameraSaveGame : USaveGame {
	public static UClass StaticClass() {return default;}
	///<summary>Waypoints</summary>
	public TMap<string,FVirtualCameraWaypoint> Waypoints;
	///<summary>Screenshots</summary>
	public TMap<string,FVirtualCameraScreenshot> Screenshots;
	///<summary>HomeWaypointName</summary>
	public string HomeWaypointName;
	///<summary>CameraSettings</summary>
	public FVirtualCameraSettings CameraSettings;
	///<summary>SettingsPresets</summary>
	public TMap<string,FVirtualCameraSettingsPreset> SettingsPresets;
	///<summary>SaveSlotName</summary>
	public string SaveSlotName;
	///<summary>UserIndex</summary>
	public uint UserIndex;
	///<summary>WaypointIndex</summary>
	public int WaypointIndex;
	///<summary>ScreenshotIndex</summary>
	public int ScreenshotIndex;
	///<summary>PresetIndex</summary>
	public int PresetIndex;
}
