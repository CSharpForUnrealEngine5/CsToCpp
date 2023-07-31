#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>The results of the meter analysis.</summary>
[CppInclude("Meter.h")]
public partial struct FMeterResults {
	public float TimeSeconds;
	public float MeterValue;
	public float PeakValue;
	public int NumSamplesClipping;
	public float ClippingValue;
}
