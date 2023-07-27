#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("IVirtualCameraPresetContainer.h")]
public partial class UVirtualCameraPresetContainer : UInterface {
// VirtualCameraPresetContainer
	public  string SavePreset(bool bSaveCameraSettings,bool bSaveStabilization,bool bSaveAxisLocking,bool bSaveMotionScale) { return default; }
	public  bool LoadPreset(string PresetName) { return default; }
	public  int DeletePreset(string PresetName) { return default; }
	public  TMap<string,FVirtualCameraSettingsPreset> GetSettingsPresets() { return default; }
}
