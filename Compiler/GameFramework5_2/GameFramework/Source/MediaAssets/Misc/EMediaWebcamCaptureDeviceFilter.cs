#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Misc/MediaBlueprintFunctionLibrary.h")]
///<summary>Filter flags for the EnumerateWebcamCaptureDevices BP function.</summary>
public enum EMediaWebcamCaptureDeviceFilter {
	None=0,
	DepthSensor=1,
	Front=2,
	Rear=4,
	Unknown=8,
}
