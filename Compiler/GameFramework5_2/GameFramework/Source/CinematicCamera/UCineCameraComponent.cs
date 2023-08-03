#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A specialized version of a camera component, geared toward cinematic usage.</summary>
[CppInclude("CineCameraComponent.h")]
public partial class UCineCameraComponent : UCameraComponent {
	public static UClass StaticClass() {return default;}
	///<summary>FilmbackSettings_DEPRECATED</summary>
	public FCameraFilmbackSettings FilmbackSettings_DEPRECATED;
	///<summary>Controls the filmback of the camera.</summary>
	public FCameraFilmbackSettings Filmback;
	///<summary>SetFilmback</summary>
	public  void SetFilmback(FCameraFilmbackSettings NewFilmback) {}
	///<summary>Controls the camera&#39;s lens.</summary>
	public FCameraLensSettings LensSettings;
	///<summary>SetLensSettings</summary>
	public  void SetLensSettings(FCameraLensSettings NewLensSettings) {}
	///<summary>Controls the camera&#39;s focus.</summary>
	public FCameraFocusSettings FocusSettings;
	///<summary>SetFocusSettings</summary>
	public  void SetFocusSettings(FCameraFocusSettings NewFocusSettings) {}
	///<summary>Controls the crop settings.</summary>
	public FPlateCropSettings CropSettings;
	///<summary>SetCropSettings</summary>
	public  void SetCropSettings(FPlateCropSettings NewCropSettings) {}
	///<summary>Current focal length of the camera (i.e. controls FoV, zoom)</summary>
	public float CurrentFocalLength;
	///<summary>Current aperture, in terms of f-stop (e.g. 2.8 for f/2.8)</summary>
	public float CurrentAperture;
	///<summary>SetCurrentAperture</summary>
	public  void SetCurrentAperture(float NewCurrentAperture) {}
	///<summary>Read-only. Control this value via FocusSettings.</summary>
	public float CurrentFocusDistance;
	///<summary>bOverride_CustomNearClippingPlane</summary>
	public bool bOverride_CustomNearClippingPlane;
	///<summary>Set bOverride_CustomNearClippingPlane to true if you want to use a custom clipping plane instead of GNearClippingPlane.</summary>
	public float CustomNearClippingPlane;
	///<summary>Read-only. Control this value with CurrentFocalLength (and filmback settings).</summary>
	public float CurrentHorizontalFOV;
	///<summary>SetCurrentFocalLength</summary>
	public  void SetCurrentFocalLength(float InFocalLength) {}
	///<summary>Sets near clipping plane of the cine camera.</summary>
	public  void SetCustomNearClippingPlane(float NewCustomNearClippingPlane) {}
	///<summary>Returns the horizonal FOV of the camera with current settings.</summary>
	public  float GetHorizontalFieldOfView() { return default; }
	///<summary>Returns the vertical FOV of the camera with current settings.</summary>
	public  float GetVerticalFieldOfView() { return default; }
	///<summary>Returns the filmback name of the camera with the current settings.</summary>
	public  string GetFilmbackPresetName() { return default; }
	///<summary>GetDefaultFilmbackPresetName</summary>
	public  string GetDefaultFilmbackPresetName() { return default; }
	///<summary>Set the current preset settings by preset name.</summary>
	public  void SetFilmbackPresetByName(string InPresetName) {}
	///<summary>Returns the lens name of the camera with the current settings.</summary>
	public  string GetLensPresetName() { return default; }
	///<summary>Set the current lens settings by preset name.</summary>
	public  void SetLensPresetByName(string InPresetName) {}
	///<summary>Returns the lens name of the camera with the current settings.</summary>
	public  string GetCropPresetName() { return default; }
	///<summary>Set the current lens settings by preset name.</summary>
	public  void SetCropPresetByName(string InPresetName) {}
	///<summary>GetFilmbackPresetsCopy</summary>
	public static TArray<FNamedFilmbackPreset> GetFilmbackPresetsCopy() { return default; }
	///<summary>GetLensPresetsCopy</summary>
	public static TArray<FNamedLensPreset> GetLensPresetsCopy() { return default; }
	///<summary>Mesh used for debug focus plane visualization</summary>
	public UStaticMesh FocusPlaneVisualizationMesh;
	///<summary>Material used for debug focus plane visualization</summary>
	public UMaterial FocusPlaneVisualizationMaterial;
	///<summary>Component for the debug focus plane visualization</summary>
	public UStaticMeshComponent DebugFocusPlaneComponent;
	///<summary>Dynamic material instance for the debug focus plane visualization</summary>
	public UMaterialInstanceDynamic DebugFocusPlaneMID;
	///<summary>FilmbackPresets</summary>
	public TArray<FNamedFilmbackPreset> FilmbackPresets;
	///<summary>LensPresets</summary>
	public TArray<FNamedLensPreset> LensPresets;
	///<summary>DefaultFilmbackPresetName_DEPRECATED</summary>
	public string DefaultFilmbackPresetName_DEPRECATED;
	///<summary>DefaultFilmbackPreset</summary>
	public string DefaultFilmbackPreset;
	///<summary>DefaultLensPresetName</summary>
	public string DefaultLensPresetName;
	///<summary>DefaultLensFocalLength</summary>
	public float DefaultLensFocalLength;
	///<summary>DefaultLensFStop</summary>
	public float DefaultLensFStop;
}
