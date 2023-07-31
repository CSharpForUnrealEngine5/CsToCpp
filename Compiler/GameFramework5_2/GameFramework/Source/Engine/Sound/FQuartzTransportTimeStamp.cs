#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Transport Time stamp, used for tracking the musical time stamp on a clock</summary>
[CppInclude("Sound/QuartzQuantizationUtilities.h")]
public partial struct FQuartzTransportTimeStamp {
	public int Bars;
	public int Beat;
	public float BeatFraction;
	public float Seconds;
}
