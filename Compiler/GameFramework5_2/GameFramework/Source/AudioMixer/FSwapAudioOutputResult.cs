#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Out structure for use with AudioMixerBlueprintLibrary::SwapAudioOutputDevice</summary>
[CppInclude("AudioMixerBlueprintLibrary.h")]
public partial struct FSwapAudioOutputResult {
	public string CurrentDeviceId;
	public string RequestedDeviceId;
	public ESwapAudioOutputDeviceResultState Result;
}
