#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Derive from this class to store the Input data. It is referenced in the Common Input Settings, found in the project settings UI.</summary>
[CppInclude("CommonInputBaseTypes.h")]
public partial class UCommonInputBaseControllerData : UObject {
	///<summary>SetButtonImageHeightTo</summary>
	public int SetButtonImageHeightTo;
	///<summary>InputType</summary>
	public ECommonInputType InputType;
	///<summary>GamepadName</summary>
	public string GamepadName;
	///<summary>GamepadDisplayName</summary>
	public string GamepadDisplayName;
	///<summary>GamepadCategory</summary>
	public string GamepadCategory;
	///<summary>GamepadPlatformName</summary>
	public string GamepadPlatformName;
	///<summary>GamepadHardwareIdMapping</summary>
	public TArray<FInputDeviceIdentifierPair> GamepadHardwareIdMapping;
	///<summary>ControllerTexture</summary>
	public TSoftObjectPtr<UTexture2D> ControllerTexture;
	///<summary>ControllerButtonMaskTexture</summary>
	public TSoftObjectPtr<UTexture2D> ControllerButtonMaskTexture;
	///<summary>InputBrushDataMap</summary>
	public TArray<FCommonInputKeyBrushConfiguration> InputBrushDataMap;
	///<summary>InputBrushKeySets</summary>
	public TArray<FCommonInputKeySetBrushConfiguration> InputBrushKeySets;
	///<summary>GetRegisteredGamepads</summary>
	public static TArray<string> GetRegisteredGamepads() { return default; }
}
