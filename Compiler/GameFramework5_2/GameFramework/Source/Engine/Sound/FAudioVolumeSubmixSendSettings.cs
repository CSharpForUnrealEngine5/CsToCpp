#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Sound/AudioVolume.h")]
///<summary>Struct to determine dynamic submix send data for use with audio volumes.</summary>
public partial struct FAudioVolumeSubmixSendSettings {
// AudioVolumeSubmixSendSettings
	public EAudioVolumeLocationState ListenerLocationState;
	public EAudioVolumeLocationState SourceLocationState_DEPRECATED;
	public TArray<FSoundSubmixSendInfo> SubmixSends;
}
