namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RawInputSettings.h")]
public partial class URawInputSettings : UDeveloperSettings {
	public static UClass StaticClass() {return default;}
	///<summary>List of bindings to apply based on Vendor and Product Id, these are applied in order. To set a default, add an entry with empty product/vendor id at the end of the array</summary>
	public TArray<FRawInputDeviceConfiguration> DeviceConfigurations;
	///<summary>Whether the plugin should try to register a default device to handle generic gamepads and joysticks</summary>
	public bool bRegisterDefaultDevice;
}
