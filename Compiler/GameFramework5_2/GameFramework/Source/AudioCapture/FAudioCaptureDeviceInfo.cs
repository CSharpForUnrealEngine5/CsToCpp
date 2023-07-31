#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Struct defining the time synth global quantization settings</summary>
[CppInclude("AudioCapture.h")]
public partial struct FAudioCaptureDeviceInfo {
	public string DeviceName;
	public int NumInputChannels;
	public int SampleRate;
}
