namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>ULoudnessSettings</summary>
[CppInclude("Loudness.h")]
public partial class ULoudnessSettings : UAudioSynesthesiaSettings {
	public static UClass StaticClass() {return default;}
	///<summary>Number of seconds between loudness measurements</summary>
	public float AnalysisPeriod;
	///<summary>Minimum analysis frequency for calculating loudness.</summary>
	public float MinimumFrequency;
	///<summary>Maximum analysis frequency for calculating loudness.</summary>
	public float MaximumFrequency;
	///<summary>Type of equal loudness curve used in calculations</summary>
	public ELoudnessCurveTypeEnum CurveType;
	///<summary>dB level to denote silence.  Used when calculating normalized loudness.</summary>
	public float NoiseFloorDb;
	///<summary>dB level to denote silence.  Used when calculating normalized loudness.</summary>
	public float ExpectedMaxLoudness;
}
