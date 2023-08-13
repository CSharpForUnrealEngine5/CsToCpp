namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Set the color of an Input Device to a static color. This will NOT reset the device color when the property</summary>
[CppInclude("GameFramework/InputDeviceProperties.h")]
public partial class UColorInputDeviceProperty : UInputDeviceProperty {
	public static UClass StaticClass() {return default;}
	///<summary>Default color data that will be used by default. Device Specific overrides will be used when the current input device matches</summary>
	public FDeviceColorData ColorData;
	///<summary>A map of device specific color data. If no overrides are specified, the Default hardware data will be used</summary>
	public TMap<string,FDeviceColorData> DeviceOverrideData;
}
