namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Configuration of an AJA timecode.</summary>
[CppInclude("AjaDeviceProvider.h")]
public partial struct FAjaMediaTimecodeReference {
	public FMediaIODevice Device;
	public int LtcIndex;
	public FFrameRate LtcFrameRate;
}
