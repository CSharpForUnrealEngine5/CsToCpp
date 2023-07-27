#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("CommonInputBaseTypes.h")]
///<summary>Derive from this class to store the Input data. It is referenced in the Common Input Settings, found in the project settings UI.</summary>
public partial class UCommonInputBaseControllerData : UObject {
// CommonInputBaseControllerData
	public int SetButtonImageHeightTo;
	public ECommonInputType InputType;
	public string GamepadName;
	public string GamepadDisplayName;
	public string GamepadCategory;
	public string GamepadPlatformName;
	public TArray<FInputDeviceIdentifierPair> GamepadHardwareIdMapping;
	public TSoftObjectPtr<UTexture2D> ControllerTexture;
	public TSoftObjectPtr<UTexture2D> ControllerButtonMaskTexture;
	public TArray<FCommonInputKeyBrushConfiguration> InputBrushDataMap;
	public TArray<FCommonInputKeySetBrushConfiguration> InputBrushKeySets;
	public static TArray<string> GetRegisteredGamepads() { return default; }
}
