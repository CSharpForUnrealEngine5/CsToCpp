#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("LoudnessNRT.h")]
///<summary>ULoudnessNRTSettings</summary>
public partial class ULoudnessNRTSettings : UAudioSynesthesiaNRTSettings {
// LoudnessNRTSettings
	public float AnalysisPeriod;
	public float MinimumFrequency;
	public float MaximumFrequency;
	public ELoudnessNRTCurveTypeEnum CurveType;
	public float NoiseFloorDb;
}
