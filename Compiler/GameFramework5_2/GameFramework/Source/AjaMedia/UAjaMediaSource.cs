#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AjaMediaSource.h")]
///<summary>Media source for AJA streams.</summary>
public partial class UAjaMediaSource : UTimeSynchronizableMediaSource {
// AjaMediaSource
	public FMediaIOConfiguration MediaConfiguration;
	public EMediaIOTimecodeFormat TimecodeFormat_DEPRECATED;
	public EMediaIOAutoDetectableTimecodeFormat AutoDetectableTimecodeFormat;
	public bool bCaptureWithAutoCirculating;
	public bool bCaptureAncillary;
	public int MaxNumAncillaryFrameBuffer;
	public bool bCaptureAudio;
	public EAjaMediaAudioChannel AudioChannel;
	public int MaxNumAudioFrameBuffer;
	public bool bCaptureVideo;
	public EAjaMediaSourceColorFormat ColorFormat;
	public bool bIsSRGBInput;
	public int MaxNumVideoFrameBuffer;
	public bool bLogDropFrame;
	public bool bEncodeTimecodeInTexel;
}
