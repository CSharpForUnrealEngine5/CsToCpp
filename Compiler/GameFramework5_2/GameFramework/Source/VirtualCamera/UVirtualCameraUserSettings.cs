#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Virtual Camera User Settings</summary>
[CppInclude("VirtualCameraUserSettings.h")]
public partial class UVirtualCameraUserSettings : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Controls interpolation speed when smoothing when changing focus distance. This is used to set the value of FocusSmoothingInterpSpeed in the Virtual camera CineCamera component</summary>
	public float FocusInterpSpeed;
	///<summary>Controls how fast the camera moves when using joysticks</summary>
	public float JoysticksSpeed;
	///<summary>Sets the maximum possible joystick speed</summary>
	public float MaxJoysticksSpeed;
	///<summary>Whether the map is displayed using grayscale or full color</summary>
	public bool bIsMapGrayscale;
	///<summary>Whether to change camera lens and fstop when teleporting to a screenshot to those with which the screenshot was taken</summary>
	public bool bOverrideCameraSettingsOnTeleportToScreenshot;
	///<summary>Stores the filmback preset name selected by the user</summary>
	public string VirtualCameraFilmback;
	///<summary>Whether to display film leader when recording a take</summary>
	public bool bDisplayFilmLeader;
	///<summary>Whether to teleport to the home bookmark when VCam starts</summary>
	public bool bTeleportOnStart;
	///<summary>Default Vcam Class for Vcam Operator Panel</summary>
	public TSoftObjectPtr<UClass> DefaultVCamClass;
	///<summary>AxisMappings</summary>
	public TArray<FInputAxisKeyMapping> AxisMappings;
	///<summary>ActionMappings</summary>
	public TArray<FInputActionKeyMapping> ActionMappings;
	///<summary>Get FocusInterpSpeed variable</summary>
	public  float GetFocusInterpSpeed() { return default; }
	///<summary>Set FocusInterpSpeed variable</summary>
	public  void SetFocusInterpSpeed(float InFocusInterpSpeed) {}
	///<summary>Get JoysticksSpeed variable</summary>
	public  float GetJoysticksSpeed() { return default; }
	///<summary>Set JoysticksSpeed variable</summary>
	public  void SetJoysticksSpeed(float InJoysticksSpeed) {}
	///<summary>Get MaxJoysticksSpeed variable</summary>
	public  float GetMaxJoysticksSpeed() { return default; }
	///<summary>Set MaxJoysticksSpeed variable</summary>
	public  void SetMaxJoysticksSpeed(float InMaxJoysticksSpeed) {}
	///<summary>Get bIsMapGrayscale variable</summary>
	public  bool IsMapGrayscle() { return default; }
	///<summary>Set bIsMapGrayscale variable</summary>
	public  void SetIsMapGrayscle(bool bInIsMapGrayscle) {}
	///<summary>Get bOverrideCameraSettingsOnTeleportToScreenshot variable</summary>
	public  bool GetShouldOverrideCameraSettingsOnTeleport() { return default; }
	///<summary>Set bOverrideCameraSettingsOnTeleportToScreenshot variable</summary>
	public  void SetShouldOverrideCameraSettingsOnTeleport(bool bInOverrideCameraSettings) {}
	///<summary>Get VirtualCameraFilmback variable</summary>
	public  string GetSavedVirtualCameraFilmbackPresetName() { return default; }
	///<summary>Set VirtualCameraFilmback variable</summary>
	public  void SetSavedVirtualCameraFilmbackPresetName(string InFilmback) {}
	///<summary>Get bDisplayFilmLeader variable</summary>
	public  bool GetShouldDisplayFilmLeader() { return default; }
	///<summary>Set bDisplayFilmLeader variable</summary>
	public  void SetShouldDisplayFilmLeader(bool bInDisplayFilmLeader) {}
	///<summary>Get bTeleportOnStart variable</summary>
	public  bool GetTeleportOnStart() { return default; }
	///<summary>Set bTeleportOnStart variable</summary>
	public  void SetTeleportOnStart(bool bInTeleportOnStart) {}
	///<summary>Fills the Axis/Action mappings with assosiated gamepad bindings</summary>
	public  void InjectGamepadKeybinds() {}
	///<summary>Retrieve all VirtualCamera action mappings by a certain name.</summary>
	public  void GetActionMappingsByName(string InActionName,TArray<FInputActionKeyMapping> OutMappings) {}
	///<summary>Retrieve all VirtualCamera axis mappings by a certain name.</summary>
	public  void GetAxisMappingsByName(string InAxisName,TArray<FInputAxisKeyMapping> OutMappings) {}
}
