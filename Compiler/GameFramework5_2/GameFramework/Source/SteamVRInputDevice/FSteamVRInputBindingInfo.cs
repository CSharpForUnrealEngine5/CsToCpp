namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Information about the input bindings for an action on currently active controller (i.e device path, input path, mode, slot)</summary>
[CppInclude("SteamVRInputDeviceFunctionLibrary.h")]
public partial struct FSteamVRInputBindingInfo {
	public FName DevicePathName;
	public FName InputPathName;
	public FName ModeName;
	public FName SlotName;
}
