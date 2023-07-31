#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A timecode that stores time in HH:MM:SS format with the remainder of time represented by an integer frame count.</summary>
[CppInclude("UObject/NoExportTypes.h")]
public partial struct FTimecode {
	public int Hours;
	public int Minutes;
	public int Seconds;
	public int Frames;
	public bool bDropFrameFormat;
}
