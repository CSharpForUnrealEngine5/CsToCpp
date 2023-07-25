#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AudioCapture.h")]
///<summary>Class which opens up a handle to an audio capture device.</summary>
public partial class UAudioCapture : UAudioGenerator {
// AudioCapture
	public bool GetAudioCaptureDeviceInfo(FAudioCaptureDeviceInfo OutInfo) { return default; }
	public void StartCapturingAudio() {}
	public void StopCapturingAudio() {}
	public bool IsCapturingAudio() { return default; }
}
