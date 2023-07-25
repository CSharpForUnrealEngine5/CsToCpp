#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GameFramework/InputDeviceProperties.h")]
///<summary>Set the color of an Input Device to a static color. This will NOT reset the device color when the property</summary>
public partial class UColorInputDeviceProperty : UInputDeviceProperty {
// ColorInputDeviceProperty
	public FDeviceColorData ColorData;
	public TMap<string,FDeviceColorData> DeviceOverrideData;
}
