#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Sound/AudioSettings.h")]
///<summary>The sound asset compression type to use for assets using the compression type "project defined".</summary>
public enum EDefaultAudioCompressionType {
	BinkAudio=0,
	ADPCM=1,
	PCM=2,
	PlatformSpecific=3,
}
