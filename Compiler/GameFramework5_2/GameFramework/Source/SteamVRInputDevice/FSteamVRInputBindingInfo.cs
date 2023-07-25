#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("SteamVRInputDeviceFunctionLibrary.h")]
///<summary>Information about the input bindings for an action on currently active controller (i.e device path, input path, mode, slot)</summary>
public partial struct FSteamVRInputBindingInfo {
// SteamVRInputBindingInfo
	public string DevicePathName;
	public string InputPathName;
	public string ModeName;
	public string SlotName;
}
