#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Output information for a MediaCapture.</summary>
[CppInclude("BlackmagicMediaOutput.h")]
public partial class UBlackmagicMediaOutput : UMediaOutput {
	public static UClass StaticClass() {return default;}
	///<summary>The device, port and video settings that correspond to the output.</summary>
	public FMediaIOOutputConfiguration OutputConfiguration;
	///<summary>Size of the buffer that holds rendered audio samples, a bigger buffer will produce an output of greater quality but will introduce more delay.</summary>
	public int AudioBufferSize;
	///<summary>Sample rate of the audio output.</summary>
	public EBlackmagicMediaOutputAudioSampleRate AudioSampleRate;
	///<summary>Number of audio channels to output.</summary>
	public EBlackmagicMediaAudioOutputChannelCount OutputChannelCount;
	///<summary>Bit depth of each audio sample.</summary>
	public EBlackmagicMediaOutputAudioBitDepth AudioBitDepth;
	///<summary>Whether to embed the Engine&#39;s timecode to the output frame.</summary>
	public EMediaIOTimecodeFormat TimecodeFormat;
	///<summary>Native data format internally used by the device before being converted to SDI/HDMI signal.</summary>
	public EBlackmagicMediaOutputPixelFormat PixelFormat;
	///<summary>Invert Key Output</summary>
	public bool bInvertKeyOutput;
	///<summary>Whether to capture and output audio from the engine.</summary>
	public bool bOutputAudio;
	///<summary>Number of frame used to transfer from the system memory to the Blackmagic card.</summary>
	public int NumberOfBlackmagicBuffers;
	///<summary>Only make sense in interlaced mode.</summary>
	public bool bInterlacedFieldsTimecodeNeedToMatch;
	///<summary>Whether to use multi threaded scheduling which should improve performance when outputting 4k and 8k content. (Experimental)</summary>
	public bool bUseMultithreadedScheduling;
	///<summary>Try to maintain a the engine &quot;Genlock&quot; with the VSync signal.</summary>
	public bool bWaitForSyncEvent;
	///<summary>Log a warning when there&#39;s a drop frame.</summary>
	public bool bLogDropFrame;
	///<summary>Burn Frame Timecode on the output without any frame number clipping.</summary>
	public bool bEncodeTimecodeInTexel;
}
