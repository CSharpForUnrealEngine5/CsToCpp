#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Struct to determine dynamic submix send data for use with audio volumes.</summary>
[CppInclude("Sound/AudioVolume.h")]
public partial struct FAudioVolumeSubmixSendSettings {
	public EAudioVolumeLocationState ListenerLocationState;
	public EAudioVolumeLocationState SourceLocationState_DEPRECATED;
	public TArray<FSoundSubmixSendInfo> SubmixSends;
}
