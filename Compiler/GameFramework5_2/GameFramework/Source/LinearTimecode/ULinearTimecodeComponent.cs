namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Implements a Linear timecode decoder.</summary>
[CppInclude("LinearTimecodeComponent.h")]
public partial class ULinearTimecodeComponent : USceneComponent {
	public static UClass StaticClass() {return default;}
	///<summary>The media player asset associated with this component.</summary>
	public UMediaPlayer MediaPlayer;
	///<summary>DropTimecode</summary>
	public FDropTimecode DropTimecode;
	///<summary>Get the Frame Number</summary>
	public int GetDropFrameNumber() { return default; }
	///<summary>Convert a drop timecode into a frame number</summary>
	public static void GetDropTimeCodeFrameNumber(FDropTimecode Timecode,int FrameNumber) {}
	///<summary>Convert frame number into a drop timecode</summary>
	public static void SetDropTimecodeFrameNumber(FDropTimecode Timecode,int FrameNumber,FDropTimecode OutTimecode) {}
	///<summary>Called when the timecode changes</summary>
	public FOnTimecodeChange OnTimecodeChange;
}
