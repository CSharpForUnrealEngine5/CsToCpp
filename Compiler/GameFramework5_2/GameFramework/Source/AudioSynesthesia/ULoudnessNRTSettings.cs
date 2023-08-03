#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>ULoudnessNRTSettings</summary>
[CppInclude("LoudnessNRT.h")]
public partial class ULoudnessNRTSettings : UAudioSynesthesiaNRTSettings {
	public static UClass StaticClass() {return default;}
	///<summary>Number of seconds between loudness measurements</summary>
	public float AnalysisPeriod;
	///<summary>Minimum analysis frequency for calculating loudness.</summary>
	public float MinimumFrequency;
	///<summary>Maximum analysis frequency for calculating loudness.</summary>
	public float MaximumFrequency;
	///<summary>Type of equal loudness curve used in calculations</summary>
	public ELoudnessNRTCurveTypeEnum CurveType;
	///<summary>dB level to denote silence.  Used when calculating normalized loudness.</summary>
	public float NoiseFloorDb;
}
