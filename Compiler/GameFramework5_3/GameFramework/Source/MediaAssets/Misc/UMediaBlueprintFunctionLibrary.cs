namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Blueprint library for Media related functions.</summary>
[CppInclude("Misc/MediaBlueprintFunctionLibrary.h")]
public partial class UMediaBlueprintFunctionLibrary : UBlueprintFunctionLibrary {
	public static UClass StaticClass() {return default;}
	///<summary>Enumerate available audio capture devices.</summary>
	public static void EnumerateAudioCaptureDevices(TArray<FMediaCaptureDevice> OutDevices,int Filter/*=-1*/) {}
	///<summary>Enumerate available audio capture devices.</summary>
	public static void EnumerateVideoCaptureDevices(TArray<FMediaCaptureDevice> OutDevices,int Filter/*=-1*/) {}
	///<summary>Enumerate available audio capture devices.</summary>
	public static void EnumerateWebcamCaptureDevices(TArray<FMediaCaptureDevice> OutDevices,int Filter/*=-1*/) {}
}
