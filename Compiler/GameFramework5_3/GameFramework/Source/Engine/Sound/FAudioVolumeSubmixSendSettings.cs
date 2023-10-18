namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Struct to determine dynamic submix send data for use with audio volumes.</summary>
[CppInclude("Sound/AudioVolume.h")]
public partial struct FAudioVolumeSubmixSendSettings {
	public EAudioVolumeLocationState ListenerLocationState;
	public EAudioVolumeLocationState SourceLocationState_DEPRECATED;
	public TArray<FSoundSubmixSendInfo> SubmixSends;
}
