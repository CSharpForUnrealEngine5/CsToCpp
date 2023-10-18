namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Sound/AudioBus.h")]
///<summary>The number of channels to mix audio into the source bus</summary>
public enum EAudioBusChannels {
	Mono=0,
	Stereo=1,
	Quad=3,
	FivePointOne=5,
	SevenPointOne=7,
}
