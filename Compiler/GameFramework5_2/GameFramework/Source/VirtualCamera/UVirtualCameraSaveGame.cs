#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("VirtualCameraSaveGame.h")]
public partial class UVirtualCameraSaveGame : USaveGame {
// VirtualCameraSaveGame
	public TMap<string,FVirtualCameraWaypoint> Waypoints;
	public TMap<string,FVirtualCameraScreenshot> Screenshots;
	public string HomeWaypointName;
	public FVirtualCameraSettings CameraSettings;
	public TMap<string,FVirtualCameraSettingsPreset> SettingsPresets;
	public string SaveSlotName;
	public uint UserIndex;
	public int WaypointIndex;
	public int ScreenshotIndex;
	public int PresetIndex;
}
