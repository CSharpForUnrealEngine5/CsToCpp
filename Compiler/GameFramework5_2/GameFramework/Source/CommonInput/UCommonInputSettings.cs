#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("CommonInputSettings.h")]
public partial class UCommonInputSettings : UDeveloperSettings {
// CommonInputSettings
	public static bool IsEnhancedInputSupportEnabled() { return default; }
	public TSoftObjectPtr<UClass> InputData;
	public FPerPlatformSettings PlatformInput;
	public TMap<string,FCommonInputPlatformBaseData> CommonInputPlatformData_DEPRECATED;
	public bool bEnableInputMethodThrashingProtection;
	public int InputMethodThrashingLimit;
	public double InputMethodThrashingWindowInSeconds;
	public double InputMethodThrashingCooldownInSeconds;
	public bool bAllowOutOfFocusDeviceInput;
	public bool bEnableDefaultInputConfig;
	public bool bEnableEnhancedInputSupport;
	public TSoftObjectPtr<UCommonInputActionDomainTable> ActionDomainTable;
	public UClass InputDataClass;
	public UCommonInputActionDomainTable ActionDomainTablePtr;
}
