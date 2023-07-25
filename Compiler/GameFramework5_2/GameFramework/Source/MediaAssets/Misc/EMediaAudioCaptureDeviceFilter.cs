#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Misc/MediaBlueprintFunctionLibrary.h")]
///<summary>Filter flags for the EnumerateAudioCaptureDevices BP function.</summary>
public enum EMediaAudioCaptureDeviceFilter {
	None=0,
	Card=1,
	Microphone=2,
	Software=4,
	Unknown=8,
}
