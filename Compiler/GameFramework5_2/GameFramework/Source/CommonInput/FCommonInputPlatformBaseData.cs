namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>DEPRECATED Legacy!</summary>
[CppInclude("CommonInputBaseTypes.h")]
public partial struct FCommonInputPlatformBaseData {
	public ECommonInputType DefaultInputType;
	public bool bSupportsMouseAndKeyboard;
	public bool bSupportsGamepad;
	public string DefaultGamepadName;
	public bool bCanChangeGamepadType;
	public bool bSupportsTouch;
	public TArray<TSoftObjectPtr<UClass>> ControllerData;
	public TArray<UClass> ControllerDataClasses;
}
