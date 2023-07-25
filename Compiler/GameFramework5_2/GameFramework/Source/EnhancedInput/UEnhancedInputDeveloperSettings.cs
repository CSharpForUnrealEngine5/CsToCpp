#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("EnhancedInputDeveloperSettings.h")]
///<summary>Developer settings for Enhanced Input</summary>
public partial class UEnhancedInputDeveloperSettings : UDeveloperSettingsBackedByCVars {
// EnhancedInputDeveloperSettings
	public TArray<FDefaultContextSetting> DefaultMappingContexts;
	public TArray<FDefaultContextSetting> DefaultWorldSubsystemMappingContexts;
	public TSoftObjectPtr<UClass> DefaultWorldInputClass;
	public FPerPlatformSettings PlatformSettings;
	public bool bEnableDefaultMappingContexts;
	public bool bShouldOnlyTriggerLastActionInChord;
	public bool bEnableWorldSubsystem;
	public bool bShouldLogAllWorldSubsystemInputs;
}
