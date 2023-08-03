#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Class which opens up a handle to an audio capture device.</summary>
[CppInclude("AudioCapture.h")]
public partial class UAudioCapture : UAudioGenerator {
	public static UClass StaticClass() {return default;}
	///<summary>Returns the audio capture device info</summary>
	public  bool GetAudioCaptureDeviceInfo(FAudioCaptureDeviceInfo OutInfo) { return default; }
	///<summary>Starts capturing audio</summary>
	public  void StartCapturingAudio() {}
	///<summary>Stops capturing audio</summary>
	public  void StopCapturingAudio() {}
	///<summary>Returns true if capturing audio</summary>
	public  bool IsCapturingAudio() { return default; }
}
