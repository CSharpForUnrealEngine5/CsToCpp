namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Developer settings for Enhanced Input</summary>
[CppInclude("EnhancedInputDeveloperSettings.h")]
public partial class UEnhancedInputDeveloperSettings : UDeveloperSettingsBackedByCVars {
	public static UClass StaticClass() {return default;}
	///<summary>Array of any input mapping contexts that you want to be applied by default to the Enhanced Input local player subsystem.</summary>
	public TArray<FDefaultContextSetting> DefaultMappingContexts;
	///<summary>Array of any input mapping contexts that you want to be applied by default to the Enhanced Input world subsystem.</summary>
	public TArray<FDefaultContextSetting> DefaultWorldSubsystemMappingContexts;
	///<summary>Platform specific settings for Enhanced Input.</summary>
	public FPerPlatformSettings PlatformSettings;
	///<summary>The class that should be used for the User Settings by each Enhanced Input subsystem.</summary>
	public TSoftObjectPtr<UClass> UserSettingsClass;
	///<summary>The default class for the player mappable key profile, used to store the key mappings set by the player in the user settings.</summary>
	public TSoftObjectPtr<UClass> DefaultPlayerMappableKeyProfileClass;
	///<summary>The default player input class that the Enhanced Input world subsystem will use.</summary>
	public TSoftObjectPtr<UClass> DefaultWorldInputClass;
	///<summary>If true, then any in progress Enhanced Input Actions will fire Cancelled and Triggered events</summary>
	public bool bSendTriggeredEventsWhenInputIsFlushed;
	///<summary>If true, then an instance of the User Settings Class will be created on each Enhanced Input subsystem.</summary>
	public bool bEnableUserSettings;
	///<summary>If true, then the DefaultMappingContexts will be applied to all Enhanced Input Subsystems.</summary>
	public bool bEnableDefaultMappingContexts;
	///<summary>If true, then only the last action in a ChordedAction trigger will be fired.</summary>
	public bool bShouldOnlyTriggerLastActionInChord;
	///<summary>If true, then a warning will be logged when a UPlayerMappableInputConfig that has been marked as deprecated is used.</summary>
	public bool bLogOnDeprecatedConfigUsed;
	///<summary>If true, then the world subsystem will be created.</summary>
	public bool bEnableWorldSubsystem;
	///<summary>If true then the Enhanced Input world subsystem will log all input that is being processed by it (keypresses, analog values, etc)</summary>
	public bool bShouldLogAllWorldSubsystemInputs;
}
