#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("CommonInputSettings.h")]
public partial class UCommonInputSettings : UDeveloperSettings {
	public static UClass StaticClass() {return default;}
	///<summary>Static version of enhanced input support check, exists to hide based on edit condition</summary>
	public static bool IsEnhancedInputSupportEnabled() { return default; }
	///<summary>Create a derived asset from UCommonUIInputData to store Input data for your game.</summary>
	public TSoftObjectPtr<UClass> InputData;
	///<summary>PlatformInput</summary>
	public FPerPlatformSettings PlatformInput;
	///<summary>CommonInputPlatformData_DEPRECATED</summary>
	public TMap<string,FCommonInputPlatformBaseData> CommonInputPlatformData_DEPRECATED;
	///<summary>bEnableInputMethodThrashingProtection</summary>
	public bool bEnableInputMethodThrashingProtection;
	///<summary>InputMethodThrashingLimit</summary>
	public int InputMethodThrashingLimit;
	///<summary>InputMethodThrashingWindowInSeconds</summary>
	public double InputMethodThrashingWindowInSeconds;
	///<summary>InputMethodThrashingCooldownInSeconds</summary>
	public double InputMethodThrashingCooldownInSeconds;
	///<summary>bAllowOutOfFocusDeviceInput</summary>
	public bool bAllowOutOfFocusDeviceInput;
	///<summary>Controls whether a default Input Config will be set when the active CommonActivatableWidgets do not specify a desired one.</summary>
	public bool bEnableDefaultInputConfig;
	///<summary>Controls if Enhanced Input Support plugin-wide. Requires restart due to caching.</summary>
	public bool bEnableEnhancedInputSupport;
	///<summary>Create a derived asset from UCommonInputActionDomainTable to store ordered ActionDomain data for your game</summary>
	public TSoftObjectPtr<UCommonInputActionDomainTable> ActionDomainTable;
	///<summary>InputDataClass</summary>
	public UClass InputDataClass;
	///<summary>ActionDomainTablePtr</summary>
	public UCommonInputActionDomainTable ActionDomainTablePtr;
}
