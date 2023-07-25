#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("CommonInputBaseTypes.h")]
///<summary>DEPRECATED Legacy!</summary>
public partial struct FCommonInputPlatformBaseData {
// CommonInputPlatformBaseData
	public ECommonInputType DefaultInputType;
	public bool bSupportsMouseAndKeyboard;
	public bool bSupportsGamepad;
	public string DefaultGamepadName;
	public bool bCanChangeGamepadType;
	public bool bSupportsTouch;
	public TArray<TSoftObjectPtr<UClass>> ControllerData;
	public TArray<UClass> ControllerDataClasses;
}
