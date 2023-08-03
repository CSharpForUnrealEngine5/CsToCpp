#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Read the LTC from the audio capture device.</summary>
[CppInclude("AudioCaptureTimecodeProvider.h")]
public partial class UAudioCaptureTimecodeProvider : UGenlockedTimecodeProvider {
	public static UClass StaticClass() {return default;}
	///<summary>Detect the frame rate from the audio source.</summary>
	public bool bDetectFrameRate;
	///<summary>When detecting the frame rate. Assume the frame rate is a drop frame format.</summary>
	public bool bAssumeDropFrameFormat;
	///<summary>Frame expected from the audio source.</summary>
	public FFrameRate FrameRate;
	///<summary>Index of the Channel to used for the capture.</summary>
	public int AudioChannel;
}
