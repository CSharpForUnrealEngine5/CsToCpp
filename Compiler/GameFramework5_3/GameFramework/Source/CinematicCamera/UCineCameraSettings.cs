namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("CineCameraSettings.h")]
public partial class UCineCameraSettings : UDeveloperSettings {
	public static UClass StaticClass() {return default;}
	///<summary>Name of the default lens preset</summary>
	public string DefaultLensPresetName;
	///<summary>Default focal length (will be constrained by default lens)</summary>
	public float DefaultLensFocalLength;
	///<summary>Default aperture (will be constrained by default lens)</summary>
	public float DefaultLensFStop;
	///<summary>List of available lens presets</summary>
	public TArray<FNamedLensPreset> LensPresets;
	///<summary>Name of the default filmback preset</summary>
	public string DefaultFilmbackPreset;
	///<summary>List of available filmback presets</summary>
	public TArray<FNamedFilmbackPreset> FilmbackPresets;
	///<summary>Name of the default crop preset</summary>
	public string DefaultCropPresetName;
	///<summary>List of available crop presets</summary>
	public TArray<FNamedPlateCropPreset> CropPresets;
	///<summary>Gets the Lens settings associated with a given preset name</summary>
	public bool GetLensPresetByName(string PresetName,FCameraLensSettings LensSettings) { return default; }
	///<summary>Gets the Filmback settings associated with a given preset name</summary>
	public bool GetFilmbackPresetByName(string PresetName,FCameraFilmbackSettings FilmbackSettings) { return default; }
	///<summary>Gets the Crop settings associated with a given preset name</summary>
	public bool GetCropPresetByName(string PresetName,FPlateCropSettings CropSettings) { return default; }
	///<summary>GetCineCameraSettings</summary>
	public static UCineCameraSettings GetCineCameraSettings() { return default; }
	///<summary>Internal Blueprint Setter functions that call SaveConfig after setting the variable to ensure settings persist</summary>
	public void SetDefaultLensPresetName(string InDefaultLensPresetName) {}
	///<summary>SetDefaultLensFocalLength</summary>
	public void SetDefaultLensFocalLength(float InDefaultLensFocalLength) {}
	///<summary>SetDefaultLensFStop</summary>
	public void SetDefaultLensFStop(float InDefaultLensFStop) {}
	///<summary>SetLensPresets</summary>
	public void SetLensPresets(TArray<FNamedLensPreset> InLensPresets) {}
	///<summary>SetDefaultFilmbackPreset</summary>
	public void SetDefaultFilmbackPreset(string InDefaultFilmbackPreset) {}
	///<summary>SetFilmbackPresets</summary>
	public void SetFilmbackPresets(TArray<FNamedFilmbackPreset> InFilmbackPresets) {}
	///<summary>SetDefaultCropPresetName</summary>
	public void SetDefaultCropPresetName(string InDefaultCropPresetName) {}
	///<summary>SetCropPresets</summary>
	public void SetCropPresets(TArray<FNamedPlateCropPreset> InCropPresets) {}
	///<summary>Functions used for the GetOptions metadata</summary>
	public TArray<string> GetLensPresetNames() { return default; }
	///<summary>GetFilmbackPresetNames</summary>
	public TArray<string> GetFilmbackPresetNames() { return default; }
	///<summary>GetCropPresetNames</summary>
	public TArray<string> GetCropPresetNames() { return default; }
}
