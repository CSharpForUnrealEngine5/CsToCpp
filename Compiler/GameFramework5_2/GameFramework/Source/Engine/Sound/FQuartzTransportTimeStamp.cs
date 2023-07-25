#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Sound/QuartzQuantizationUtilities.h")]
///<summary>Transport Time stamp, used for tracking the musical time stamp on a clock</summary>
public partial struct FQuartzTransportTimeStamp {
// QuartzTransportTimeStamp
	public int Bars;
	public int Beat;
	public float BeatFraction;
	public float Seconds;
}
