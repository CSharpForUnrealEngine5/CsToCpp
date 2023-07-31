#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>UOnsetNRTSettings</summary>
[CppInclude("OnsetNRT.h")]
public partial class UOnsetNRTSettings : UAudioSynesthesiaNRTSettings {
	///<summary>If true, multichannel audio is downmixed to mono with equal amplitude scaling. If false, each channel gets it&#39;s own onset result.</summary>
	public bool bDownmixToMono;
	///<summary>Onset timestamp granularity onsets. Lower granularity takes longer to compute.</summary>
	public float GranularityInSeconds;
	///<summary>Sensitivity of onset detector. Higher sensitivity will find more onsets.</summary>
	public float Sensitivity;
	///<summary>Starting frequency for onset anlaysis.</summary>
	public float MinimumFrequency;
	///<summary>Starting frequency for onset anlaysis.</summary>
	public float MaximumFrequency;
}
