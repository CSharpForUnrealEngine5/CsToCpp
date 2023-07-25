#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("VirtualCameraUserSettings.h")]
///<summary>Virtual Camera User Settings</summary>
public partial class UVirtualCameraUserSettings : UObject {
// VirtualCameraUserSettings
	public float FocusInterpSpeed;
	public float JoysticksSpeed;
	public float MaxJoysticksSpeed;
	public bool bIsMapGrayscale;
	public bool bOverrideCameraSettingsOnTeleportToScreenshot;
	public string VirtualCameraFilmback;
	public bool bDisplayFilmLeader;
	public bool bTeleportOnStart;
	public TSoftObjectPtr<UClass> DefaultVCamClass;
	public TArray<FInputAxisKeyMapping> AxisMappings;
	public TArray<FInputActionKeyMapping> ActionMappings;
	public float GetFocusInterpSpeed() { return default; }
	public void SetFocusInterpSpeed(float InFocusInterpSpeed) {}
	public float GetJoysticksSpeed() { return default; }
	public void SetJoysticksSpeed(float InJoysticksSpeed) {}
	public float GetMaxJoysticksSpeed() { return default; }
	public void SetMaxJoysticksSpeed(float InMaxJoysticksSpeed) {}
	public bool IsMapGrayscle() { return default; }
	public void SetIsMapGrayscle(bool bInIsMapGrayscle) {}
	public bool GetShouldOverrideCameraSettingsOnTeleport() { return default; }
	public void SetShouldOverrideCameraSettingsOnTeleport(bool bInOverrideCameraSettings) {}
	public string GetSavedVirtualCameraFilmbackPresetName() { return default; }
	public void SetSavedVirtualCameraFilmbackPresetName(string InFilmback) {}
	public bool GetShouldDisplayFilmLeader() { return default; }
	public void SetShouldDisplayFilmLeader(bool bInDisplayFilmLeader) {}
	public bool GetTeleportOnStart() { return default; }
	public void SetTeleportOnStart(bool bInTeleportOnStart) {}
	public void InjectGamepadKeybinds() {}
	public void GetActionMappingsByName(string InActionName,TArray<FInputActionKeyMapping> OutMappings) {}
	public void GetAxisMappingsByName(string InAxisName,TArray<FInputAxisKeyMapping> OutMappings) {}
}
