#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Misc/MediaBlueprintFunctionLibrary.h")]
///<summary>Blueprint library for Media related functions.</summary>
public partial class UMediaBlueprintFunctionLibrary : UBlueprintFunctionLibrary {
// MediaBlueprintFunctionLibrary
	public void EnumerateAudioCaptureDevices(TArray<FMediaCaptureDevice> OutDevices,int Filter/*=-1*/) {}
	public void EnumerateVideoCaptureDevices(TArray<FMediaCaptureDevice> OutDevices,int Filter/*=-1*/) {}
	public void EnumerateWebcamCaptureDevices(TArray<FMediaCaptureDevice> OutDevices,int Filter/*=-1*/) {}
}
