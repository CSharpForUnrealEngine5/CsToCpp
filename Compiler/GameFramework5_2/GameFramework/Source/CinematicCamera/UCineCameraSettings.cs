#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("CineCameraSettings.h")]
public partial class UCineCameraSettings : UDeveloperSettings {
// CineCameraSettings
	public string DefaultLensPresetName;
	public float DefaultLensFocalLength;
	public float DefaultLensFStop;
	public TArray<FNamedLensPreset> LensPresets;
	public string DefaultFilmbackPreset;
	public TArray<FNamedFilmbackPreset> FilmbackPresets;
	public string DefaultCropPresetName;
	public TArray<FNamedPlateCropPreset> CropPresets;
	public bool GetLensPresetByName(string PresetName,FCameraLensSettings LensSettings) { return default; }
	public bool GetFilmbackPresetByName(string PresetName,FCameraFilmbackSettings FilmbackSettings) { return default; }
	public bool GetCropPresetByName(string PresetName,FPlateCropSettings CropSettings) { return default; }
	public UObject GetCineCameraSettings() { return default; }
	public void SetDefaultLensPresetName(string InDefaultLensPresetName) {}
	public void SetDefaultLensFocalLength(float InDefaultLensFocalLength) {}
	public void SetDefaultLensFStop(float InDefaultLensFStop) {}
	public void SetLensPresets(TArray<FNamedLensPreset> InLensPresets) {}
	public void SetDefaultFilmbackPreset(string InDefaultFilmbackPreset) {}
	public void SetFilmbackPresets(TArray<FNamedFilmbackPreset> InFilmbackPresets) {}
	public void SetDefaultCropPresetName(string InDefaultCropPresetName) {}
	public void SetCropPresets(TArray<FNamedPlateCropPreset> InCropPresets) {}
	public TArray<string> GetLensPresetNames() { return default; }
	public TArray<string> GetFilmbackPresetNames() { return default; }
	public TArray<string> GetCropPresetNames() { return default; }
}
