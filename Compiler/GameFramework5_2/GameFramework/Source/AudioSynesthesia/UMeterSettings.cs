#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>UMeterSettings</summary>
[CppInclude("Meter.h")]
public partial class UMeterSettings : UAudioSynesthesiaSettings {
	public static UClass StaticClass() {return default;}
	///<summary>Number of seconds between meter measurements</summary>
	public float AnalysisPeriod;
	///<summary>Meter envelope type type</summary>
	public EMeterPeakType PeakMode;
	///<summary>Meter attack time, in milliseconds</summary>
	public int MeterAttackTime;
	///<summary>Meter release time, in milliseconds.</summary>
	public int MeterReleaseTime;
	///<summary>Peak hold time, in milliseconds</summary>
	public int PeakHoldTime;
	///<summary>What volume threshold to throw clipping detection notifications.</summary>
	public float ClippingThreshold;
}
