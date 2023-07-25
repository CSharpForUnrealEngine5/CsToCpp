#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AjaMediaOutput.h")]
///<summary>Output information for an aja media capture.</summary>
public partial class UAjaMediaOutput : UMediaOutput {
// AjaMediaOutput
	public FMediaIOOutputConfiguration OutputConfiguration;
	public bool bOutputWithAutoCirculating;
	public EMediaIOTimecodeFormat TimecodeFormat;
	public EAjaMediaOutputPixelFormat PixelFormat;
	public bool bOutputIn3GLevelB;
	public bool bInvertKeyOutput;
	public bool bOutputAudio;
	public int AudioBufferSize;
	public EAjaMediaOutputChannelConfiguration NumOutputAudioChannels;
	public EAjaMediaOutputAudioSampleRate AudioSampleRate;
	public bool bOutputAudioOnAudioThread;
	public int NumberOfAJABuffers;
	public bool bInterlacedFieldsTimecodeNeedToMatch;
	public bool bWaitForSyncEvent;
	public bool bLogDropFrame;
	public bool bEncodeTimecodeInTexel;
}
