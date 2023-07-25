#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GameFramework/InputSettings.h")]
///<summary>Project wide settings for input handling</summary>
public partial class UInputSettings : UObject {
// InputSettings
	public TArray<FInputAxisConfigEntry> AxisConfig;
	public FPerPlatformSettings PlatformSettings;
	public bool bAltEnterTogglesFullscreen;
	public bool bF11TogglesFullscreen;
	public bool bUseMouseForTouch;
	public bool bEnableMouseSmoothing;
	public bool bEnableFOVScaling;
	public bool bCaptureMouseOnLaunch;
	public bool bEnableLegacyInputScales;
	public bool bEnableMotionControls;
	public bool bFilterInputByPlatformUser;
	public bool bEnableInputDeviceSubsystem;
	public bool bShouldFlushPressedKeysOnViewportFocusLost;
	public bool bEnableDynamicComponentInputBinding;
	public bool bAlwaysShowTouchInterface;
	public bool bShowConsoleOnFourFingerTap;
	public bool bEnableGestureRecognizer;
	public bool bUseAutocorrect;
	public TArray<string> ExcludedAutocorrectOS;
	public TArray<string> ExcludedAutocorrectCultures;
	public TArray<string> ExcludedAutocorrectDeviceModels;
	public EMouseCaptureMode DefaultViewportMouseCaptureMode;
	public EMouseLockMode DefaultViewportMouseLockMode;
	public float FOVScale;
	public float DoubleClickTime;
	public TArray<FInputActionKeyMapping> ActionMappings;
	public TArray<FInputAxisKeyMapping> AxisMappings;
	public TArray<FInputActionSpeechMapping> SpeechMappings;
	public TSoftObjectPtr<UClass> DefaultPlayerInputClass;
	public TSoftObjectPtr<UClass> DefaultInputComponentClass;
	public FSoftObjectPath DefaultTouchInterface;
	public TArray<FKey> ConsoleKeys;
	public UObject GetInputSettings() { return default; }
	public void AddActionMapping(FInputActionKeyMapping KeyMapping,bool bForceRebuildKeymaps/*=true*/) {}
	public void GetActionMappingByName(string InActionName,TArray<FInputActionKeyMapping> OutMappings) {}
	public void RemoveActionMapping(FInputActionKeyMapping KeyMapping,bool bForceRebuildKeymaps/*=true*/) {}
	public void AddAxisMapping(FInputAxisKeyMapping KeyMapping,bool bForceRebuildKeymaps/*=true*/) {}
	public void GetAxisMappingByName(string InAxisName,TArray<FInputAxisKeyMapping> OutMappings) {}
	public void RemoveAxisMapping(FInputAxisKeyMapping KeyMapping,bool bForceRebuildKeymaps/*=true*/) {}
	public void SaveKeyMappings() {}
	public void GetActionNames(TArray<string> ActionNames) {}
	public void GetAxisNames(TArray<string> AxisNames) {}
	public void ForceRebuildKeymaps() {}
}
