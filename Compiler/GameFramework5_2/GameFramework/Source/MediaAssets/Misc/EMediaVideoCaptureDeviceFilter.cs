namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Misc/MediaBlueprintFunctionLibrary.h")]
///<summary>Filter flags for the EnumerateVideoCaptureDevices BP function.</summary>
public enum EMediaVideoCaptureDeviceFilter {
	None=0,
	Card=1,
	Software=2,
	Unknown=4,
	Webcam=8,
}
