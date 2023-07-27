#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("LinearTimecodeComponent.h")]
///<summary>Implements a Linear timecode decoder.</summary>
public partial class ULinearTimecodeComponent : USceneComponent {
// LinearTimecodeComponent
	public UMediaPlayer MediaPlayer;
	public FDropTimecode DropTimecode;
	public  int GetDropFrameNumber() { return default; }
	public static void GetDropTimeCodeFrameNumber(FDropTimecode Timecode,int FrameNumber) {}
	public static void SetDropTimecodeFrameNumber(FDropTimecode Timecode,int FrameNumber,FDropTimecode OutTimecode) {}
	public FOnTimecodeChange OnTimecodeChange;
}
