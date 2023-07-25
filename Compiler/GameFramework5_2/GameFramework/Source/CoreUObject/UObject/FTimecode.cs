#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("UObject/NoExportTypes.h")]
///<summary>A timecode that stores time in HH:MM:SS format with the remainder of time represented by an integer frame count.</summary>
public partial struct FTimecode {
// Timecode
	public int Hours;
	public int Minutes;
	public int Seconds;
	public int Frames;
	public bool bDropFrameFormat;
}
