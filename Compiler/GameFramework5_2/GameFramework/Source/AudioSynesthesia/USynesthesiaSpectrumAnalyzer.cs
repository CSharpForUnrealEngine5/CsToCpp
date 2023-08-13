namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>USynesthesiaSpectrumAnalysisAnalyzer</summary>
[CppInclude("SynesthesiaSpectrumAnalysis.h")]
public partial class USynesthesiaSpectrumAnalyzer : UAudioAnalyzer {
	public static UClass StaticClass() {return default;}
	///<summary>The settings for the SynesthesiaSpectrumAnalysis audio analyzer.</summary>
	public USynesthesiaSpectrumAnalysisSettings Settings;
	///<summary>Delegate to receive all Spectrum results, per-channel, since last delegate call. If bDownmixToMono setting is true, results will be in channel index 0.</summary>
	public FOnSpectrumResults OnSpectrumResults;
	///<summary>Delegate to receive the latest per-channel Spectrum results. If bDownmixToMono setting is true, results will be in channel index 0.</summary>
	public FOnLatestSpectrumResults OnLatestSpectrumResults;
	///<summary>GetCenterFrequencies</summary>
	public void GetCenterFrequencies(float InSampleRate,TArray<float> OutCenterFrequencies) {}
	///<summary>GetNumCenterFrequencies</summary>
	public int GetNumCenterFrequencies() { return default; }
}
