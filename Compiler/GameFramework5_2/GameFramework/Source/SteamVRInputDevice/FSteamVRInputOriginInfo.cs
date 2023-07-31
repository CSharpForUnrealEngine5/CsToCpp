#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Information about the tracked device associated from the input source</summary>
[CppInclude("SteamVRInputDeviceFunctionLibrary.h")]
public partial struct FSteamVRInputOriginInfo {
	public int TrackedDeviceIndex;
	public string RenderModelComponentName;
	public string TrackedDeviceModel;
}
