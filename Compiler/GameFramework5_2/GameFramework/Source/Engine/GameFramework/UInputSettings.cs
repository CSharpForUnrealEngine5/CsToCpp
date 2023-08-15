namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Project wide settings for input handling</summary>
[CppInclude("GameFramework/InputSettings.h")]
public partial class UInputSettings : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>List of Axis Properties</summary>
	public TArray<FInputAxisConfigEntry> AxisConfig;
	///<summary>Platform specific settings for Input.</summary>
	public FPerPlatformSettings PlatformSettings;
	///<summary>bAltEnterTogglesFullscreen</summary>
	public bool bAltEnterTogglesFullscreen;
	///<summary>bF11TogglesFullscreen</summary>
	public bool bF11TogglesFullscreen;
	///<summary>Allow mouse to be used for touch</summary>
	public bool bUseMouseForTouch;
	///<summary>Mouse smoothing control</summary>
	public bool bEnableMouseSmoothing;
	///<summary>Scale the mouse based on the player camera manager&#39;s field of view</summary>
	public bool bEnableFOVScaling;
	///<summary>Controls if the viewport will capture the mouse on Launch of the application</summary>
	public bool bCaptureMouseOnLaunch;
	///<summary>Enable the use of legacy input scales on the player controller (InputYawScale, InputPitchScale, and InputRollScale)</summary>
	public bool bEnableLegacyInputScales;
	///<summary>If set to false, then the player controller&#39;s InputMotion function will never be called.</summary>
	public bool bEnableMotionControls;
	///<summary>If true, then the PlayerController::InputKey function will only process an input event if it</summary>
	public bool bFilterInputByPlatformUser;
	///<summary>If true, then the input device subsystem will be allowed to Initalize when the engine boots.</summary>
	public bool bEnableInputDeviceSubsystem;
	///<summary>If true, then the Player Controller will have it&#39;s Pressed Keys flushed when the input mode is changed</summary>
	public bool bShouldFlushPressedKeysOnViewportFocusLost;
	///<summary>Should components that are dynamically added via the &#39;AddComponent&#39; function at runtime have input delegates bound to them?</summary>
	public bool bEnableDynamicComponentInputBinding;
	///<summary>Should the touch input interface be shown always, or only when the platform has a touch screen?</summary>
	public bool bAlwaysShowTouchInterface;
	///<summary>Whether or not to show the console on 4 finger tap, on mobile platforms</summary>
	public bool bShowConsoleOnFourFingerTap;
	///<summary>Whether or not to use the gesture recognition system to convert touches in to gestures that can be bound and queried</summary>
	public bool bEnableGestureRecognizer;
	///<summary>If enabled, virtual keyboards will have autocorrect enabled. Currently only supported on mobile devices.</summary>
	public bool bUseAutocorrect;
	///<summary>Disables autocorrect for these operating systems, even if autocorrect is enabled. Use the format &quot;[platform] [osversion]&quot;</summary>
	public TArray<string> ExcludedAutocorrectOS;
	///<summary>Disables autocorrect for these cultures, even if autocorrect is turned on. These should be ISO-compliant language and country codes, such as &quot;en&quot; or &quot;en-US&quot;.</summary>
	public TArray<string> ExcludedAutocorrectCultures;
	///<summary>Disables autocorrect for these device models, even if autocorrect is turned in. Model IDs listed here will match against the start of the device&#39;s</summary>
	public TArray<string> ExcludedAutocorrectDeviceModels;
	///<summary>The default mouse capture mode for the game viewport</summary>
	public EMouseCaptureMode DefaultViewportMouseCaptureMode;
	///<summary>The default mouse lock state behavior when the viewport acquires capture</summary>
	public EMouseLockMode DefaultViewportMouseLockMode;
	///<summary>The scaling value to multiply the field of view by</summary>
	public float FOVScale;
	///<summary>If a key is pressed twice in this amount of time it is considered a &quot;double click&quot;</summary>
	public float DoubleClickTime;
	///<summary>List of Action Mappings</summary>
	public TArray<FInputActionKeyMapping> ActionMappings;
	///<summary>List of Axis Mappings</summary>
	public TArray<FInputAxisKeyMapping> AxisMappings;
	///<summary>List of Speech Mappings</summary>
	public TArray<FInputActionSpeechMapping> SpeechMappings;
	///<summary>Default class type for player input object. May be overridden by player controller.</summary>
	public TSoftObjectPtr<UClass> DefaultPlayerInputClass;
	///<summary>Default class type for pawn input components.</summary>
	public TSoftObjectPtr<UClass> DefaultInputComponentClass;
	///<summary>The default on-screen touch input interface for the game (can be null to disable the onscreen interface)</summary>
	public FSoftObjectPath DefaultTouchInterface;
	///<summary>The keys which open the console.</summary>
	public TArray<FKey> ConsoleKeys;
	///<summary>Returns the game local input settings (action mappings, axis mappings, etc...)</summary>
	public static UInputSettings GetInputSettings() { return default; }
	///<summary>Programmatically add an action mapping to the project defaults</summary>
	public void AddActionMapping(FInputActionKeyMapping KeyMapping,bool bForceRebuildKeymaps/*=true*/) {}
	///<summary>GetActionMappingByName</summary>
	public void GetActionMappingByName(FName InActionName,TArray<FInputActionKeyMapping> OutMappings) {}
	///<summary>Programmatically remove an action mapping to the project defaults</summary>
	public void RemoveActionMapping(FInputActionKeyMapping KeyMapping,bool bForceRebuildKeymaps/*=true*/) {}
	///<summary>Programmatically add an axis mapping to the project defaults</summary>
	public void AddAxisMapping(FInputAxisKeyMapping KeyMapping,bool bForceRebuildKeymaps/*=true*/) {}
	///<summary>Retrieve all axis mappings by a certain name.</summary>
	public void GetAxisMappingByName(FName InAxisName,TArray<FInputAxisKeyMapping> OutMappings) {}
	///<summary>Programmatically remove an axis mapping to the project defaults</summary>
	public void RemoveAxisMapping(FInputAxisKeyMapping KeyMapping,bool bForceRebuildKeymaps/*=true*/) {}
	///<summary>Flush the current mapping values to the config file</summary>
	public void SaveKeyMappings() {}
	///<summary>Populate a list of all defined action names</summary>
	public void GetActionNames(TArray<FName> ActionNames) {}
	///<summary>Populate a list of all defined axis names</summary>
	public void GetAxisNames(TArray<FName> AxisNames) {}
	///<summary>When changes are made to the default mappings, push those changes out to PlayerInput key maps</summary>
	public void ForceRebuildKeymaps() {}
}
