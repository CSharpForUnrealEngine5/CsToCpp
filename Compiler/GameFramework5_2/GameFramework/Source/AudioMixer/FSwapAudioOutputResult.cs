#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AudioMixerBlueprintLibrary.h")]
///<summary>Out structure for use with AudioMixerBlueprintLibrary::SwapAudioOutputDevice</summary>
public partial struct FSwapAudioOutputResult {
// SwapAudioOutputResult
	public string CurrentDeviceId;
	public string RequestedDeviceId;
	public ESwapAudioOutputDeviceResultState Result;
}
