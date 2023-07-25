#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("BlackmagicMediaOutput.h")]
///<summary>Output information for a MediaCapture.</summary>
public partial class UBlackmagicMediaOutput : UMediaOutput {
// BlackmagicMediaOutput
	public FMediaIOOutputConfiguration OutputConfiguration;
	public int AudioBufferSize;
	public EBlackmagicMediaOutputAudioSampleRate AudioSampleRate;
	public EBlackmagicMediaAudioOutputChannelCount OutputChannelCount;
	public EBlackmagicMediaOutputAudioBitDepth AudioBitDepth;
	public EMediaIOTimecodeFormat TimecodeFormat;
	public EBlackmagicMediaOutputPixelFormat PixelFormat;
	public bool bInvertKeyOutput;
	public bool bOutputAudio;
	public int NumberOfBlackmagicBuffers;
	public bool bInterlacedFieldsTimecodeNeedToMatch;
	public bool bUseMultithreadedScheduling;
	public bool bWaitForSyncEvent;
	public bool bLogDropFrame;
	public bool bEncodeTimecodeInTexel;
}
