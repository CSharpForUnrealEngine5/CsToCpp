#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Meter.h")]
///<summary>UMeterSettings</summary>
public partial class UMeterSettings : UAudioSynesthesiaSettings {
// MeterSettings
	public float AnalysisPeriod;
	public EMeterPeakType PeakMode;
	public int MeterAttackTime;
	public int MeterReleaseTime;
	public int PeakHoldTime;
	public float ClippingThreshold;
}
