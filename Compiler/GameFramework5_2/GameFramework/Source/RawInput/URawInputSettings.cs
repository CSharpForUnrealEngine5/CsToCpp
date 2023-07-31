#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RawInputSettings.h")]
public partial class URawInputSettings : UDeveloperSettings {
	///<summary>List of bindings to apply based on Vendor and Product Id, these are applied in order. To set a default, add an entry with empty product/vendor id at the end of the array</summary>
	public TArray<FRawInputDeviceConfiguration> DeviceConfigurations;
	///<summary>Whether the plugin should try to register a default device to handle generic gamepads and joysticks</summary>
	public bool bRegisterDefaultDevice;
}
