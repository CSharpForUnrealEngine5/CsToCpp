#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Loudness.h")]
///<summary>ULoudnessSettings</summary>
public partial class ULoudnessSettings : UAudioSynesthesiaSettings {
// LoudnessSettings
	public float AnalysisPeriod;
	public float MinimumFrequency;
	public float MaximumFrequency;
	public ELoudnessCurveTypeEnum CurveType;
	public float NoiseFloorDb;
	public float ExpectedMaxLoudness;
}
