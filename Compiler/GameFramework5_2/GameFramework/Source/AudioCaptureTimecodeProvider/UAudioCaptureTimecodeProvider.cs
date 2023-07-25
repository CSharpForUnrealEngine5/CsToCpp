#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AudioCaptureTimecodeProvider.h")]
///<summary>Read the LTC from the audio capture device.</summary>
public partial class UAudioCaptureTimecodeProvider : UGenlockedTimecodeProvider {
// AudioCaptureTimecodeProvider
	public bool bDetectFrameRate;
	public bool bAssumeDropFrameFormat;
	public FFrameRate FrameRate;
	public int AudioChannel;
}
