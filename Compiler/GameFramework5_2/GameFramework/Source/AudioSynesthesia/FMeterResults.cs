#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Meter.h")]
///<summary>The results of the meter analysis.</summary>
public partial struct FMeterResults {
// MeterResults
	public float TimeSeconds;
	public float MeterValue;
	public float PeakValue;
	public int NumSamplesClipping;
	public float ClippingValue;
}
