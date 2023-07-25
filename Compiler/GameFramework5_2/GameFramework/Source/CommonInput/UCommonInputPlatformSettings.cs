#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("CommonInputBaseTypes.h")]
public partial class UCommonInputPlatformSettings : UPlatformSettings {
// CommonInputPlatformSettings
	public ECommonInputType DefaultInputType;
	public bool bSupportsMouseAndKeyboard;
	public bool bSupportsTouch;
	public bool bSupportsGamepad;
	public string DefaultGamepadName;
	public bool bCanChangeGamepadType;
	public TArray<TSoftObjectPtr<UClass>> ControllerData;
	public TArray<UClass> ControllerDataClasses;
}
