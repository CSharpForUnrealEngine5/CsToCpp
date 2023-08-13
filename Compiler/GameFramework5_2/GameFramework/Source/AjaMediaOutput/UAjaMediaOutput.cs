namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Output information for an aja media capture.</summary>
[CppInclude("AjaMediaOutput.h")]
public partial class UAjaMediaOutput : UMediaOutput {
	public static UClass StaticClass() {return default;}
	///<summary>The device, port and video settings that correspond to the output.</summary>
	public FMediaIOOutputConfiguration OutputConfiguration;
	///<summary>The output of the Audio, Ancillary and/or video will be perform at the same time.</summary>
	public bool bOutputWithAutoCirculating;
	///<summary>Whether to embed the Engine&#39;s timecode to the output frame.</summary>
	public EMediaIOTimecodeFormat TimecodeFormat;
	///<summary>Native data format internally used by the device before being converted to SDI/HDMI signal.</summary>
	public EAjaMediaOutputPixelFormat PixelFormat;
	///<summary>If the video format is compatible with 3G Level A, do the conversion to output in LevelB.</summary>
	public bool bOutputIn3GLevelB;
	///<summary>Invert Key Output</summary>
	public bool bInvertKeyOutput;
	///<summary>Whether to capture and output audio from the engine.</summary>
	public bool bOutputAudio;
	///<summary>Size of the buffer that holds rendered audio samples, a bigger buffer will produce a more stable output signal but will introduce more delay.</summary>
	public int AudioBufferSize;
	///<summary>Number of audio channels used when output audio on the card.</summary>
	public EAjaMediaOutputChannelConfiguration NumOutputAudioChannels;
	///<summary>Audio output sample rate.</summary>
	public EAjaMediaOutputAudioSampleRate AudioSampleRate;
	///<summary>Whether to output audio on the audio thread instead of the rendering thread. Only available in Ping Pong mode. (Experimental)</summary>
	public bool bOutputAudioOnAudioThread;
	///<summary>Number of frame used to transfer from the system memory to the AJA card.</summary>
	public int NumberOfAJABuffers;
	///<summary>Only make sense in interlaced mode.</summary>
	public bool bInterlacedFieldsTimecodeNeedToMatch;
	///<summary>Try to maintain a the engine &quot;Genlock&quot; with the VSync signal.</summary>
	public bool bWaitForSyncEvent;
	///<summary>Log a warning when there&#39;s a drop frame.</summary>
	public bool bLogDropFrame;
	///<summary>Burn Frame Timecode on the output without any frame number clipping.</summary>
	public bool bEncodeTimecodeInTexel;
}
