#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("CommonInputBaseTypes.h")]
public partial class UCommonInputPlatformSettings : UPlatformSettings {
	///<summary>DefaultInputType</summary>
	public ECommonInputType DefaultInputType;
	///<summary>bSupportsMouseAndKeyboard</summary>
	public bool bSupportsMouseAndKeyboard;
	///<summary>bSupportsTouch</summary>
	public bool bSupportsTouch;
	///<summary>bSupportsGamepad</summary>
	public bool bSupportsGamepad;
	///<summary>DefaultGamepadName</summary>
	public string DefaultGamepadName;
	///<summary>bCanChangeGamepadType</summary>
	public bool bCanChangeGamepadType;
	///<summary>ControllerData</summary>
	public TArray<TSoftObjectPtr<UClass>> ControllerData;
	///<summary>ControllerDataClasses</summary>
	public TArray<UClass> ControllerDataClasses;
}
