#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Configuration of an AJA timecode.</summary>
[CppInclude("AjaDeviceProvider.h")]
public partial struct FAjaMediaTimecodeReference {
	public FMediaIODevice Device;
	public int LtcIndex;
	public FFrameRate LtcFrameRate;
}
