#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("IVirtualCameraPresetContainer.h")]
public partial class UVirtualCameraPresetContainer : UInterface {
	public static UClass StaticClass() {return default;}
	///<summary>Saves a preset into the list of presets.</summary>
	public  string SavePreset(bool bSaveCameraSettings,bool bSaveStabilization,bool bSaveAxisLocking,bool bSaveMotionScale) { return default; }
	///<summary>Loads a preset using its name as a string key.</summary>
	public  bool LoadPreset(string PresetName) { return default; }
	///<summary>Deletes a preset using its name as the key.</summary>
	public  int DeletePreset(string PresetName) { return default; }
	///<summary>Returns a sorted TMap of the current presets.</summary>
	public  TMap<string,FVirtualCameraSettingsPreset> GetSettingsPresets() { return default; }
}
