#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("BlackmagicMediaSource.h")]
///<summary>Media source description for Blackmagic.</summary>
public partial class UBlackmagicMediaSource : UTimeSynchronizableMediaSource {
// BlackmagicMediaSource
	public FMediaIOConfiguration MediaConfiguration;
	public EMediaIOTimecodeFormat TimecodeFormat_DEPRECATED;
	public EMediaIOAutoDetectableTimecodeFormat AutoDetectableTimecodeFormat;
	public bool bCaptureAudio;
	public EBlackmagicMediaAudioChannel AudioChannels;
	public int MaxNumAudioFrameBuffer;
	public bool bCaptureVideo;
	public EBlackmagicMediaSourceColorFormat ColorFormat;
	public bool bIsSRGBInput;
	public int MaxNumVideoFrameBuffer;
	public bool bLogDropFrame;
	public bool bEncodeTimecodeInTexel;
}
