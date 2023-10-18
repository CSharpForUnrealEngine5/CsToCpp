namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Platform audio output device info, in a Blueprint-readable format</summary>
[CppInclude("AudioMixerBlueprintLibrary.h")]
public partial struct FAudioOutputDeviceInfo {
	public string Name;
	public string DeviceId;
	public int NumChannels;
	public int SampleRate;
	public EAudioMixerStreamDataFormatType Format;
	public TArray<EAudioMixerChannelType> OutputChannelArray;
	public bool bIsSystemDefault;
	public bool bIsCurrentDevice;
}
