namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Media source description for Blackmagic.</summary>
[CppInclude("BlackmagicMediaSource.h")]
public partial class UBlackmagicMediaSource : UTimeSynchronizableMediaSource {
	public static UClass StaticClass() {return default;}
	///<summary>The device, port and video settings that correspond to the input.</summary>
	public FMediaIOConfiguration MediaConfiguration;
	///<summary>Use the time code embedded in the input stream.</summary>
	public EMediaIOTimecodeFormat TimecodeFormat_DEPRECATED;
	///<summary>Use the time code embedded in the input stream.</summary>
	public EMediaIOAutoDetectableTimecodeFormat AutoDetectableTimecodeFormat;
	///<summary>Capture Audio from the Blackmagic source.</summary>
	public bool bCaptureAudio;
	///<summary>Desired number of audio channel to capture.</summary>
	public EBlackmagicMediaAudioChannel AudioChannels;
	///<summary>Maximum number of audio frames to buffer.</summary>
	public int MaxNumAudioFrameBuffer;
	///<summary>Capture Video from the Blackmagic source.</summary>
	public bool bCaptureVideo;
	///<summary>Native data format internally used by the device after being converted from SDI/HDMI signal.</summary>
	public EBlackmagicMediaSourceColorFormat ColorFormat;
	///<summary>Whether the video input is in sRGB color space.</summary>
	public bool bIsSRGBInput;
	///<summary>Maximum number of video frames to buffer.</summary>
	public int MaxNumVideoFrameBuffer;
	///<summary>Log a warning when there&#39;s a drop frame.</summary>
	public bool bLogDropFrame;
	///<summary>Burn Frame Timecode in the input texture without any frame number clipping.</summary>
	public bool bEncodeTimecodeInTexel;
}
