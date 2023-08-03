#pragma warning disable CS8618,CS8603,CS1587,CS1591
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
	///<summary>The default player input class that the Enhanced Input world subsystem will use.</summary>
	public TSoftObjectPtr<UClass> DefaultWorldInputClass;
	///<summary>Platform specific settings for Enhanced Input.</summary>
	public FPerPlatformSettings PlatformSettings;
	///<summary>If true, then the DefaultMappingContexts will be applied to all Enhanced Input Subsystems.</summary>
	public bool bEnableDefaultMappingContexts;
	///<summary>If true, then only the last action in a ChordedAction trigger will be fired.</summary>
	public bool bShouldOnlyTriggerLastActionInChord;
	///<summary>If true, then the world subsystem will be created.</summary>
	public bool bEnableWorldSubsystem;
	///<summary>If true then the Enhanced Input world subsystem will log all input that is being processed by it (keypresses, analog values, etc)</summary>
	public bool bShouldLogAllWorldSubsystemInputs;
}
