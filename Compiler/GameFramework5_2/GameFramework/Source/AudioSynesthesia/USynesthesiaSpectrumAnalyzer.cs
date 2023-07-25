#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("SynesthesiaSpectrumAnalysis.h")]
///<summary>USynesthesiaSpectrumAnalysisAnalyzer</summary>
public partial class USynesthesiaSpectrumAnalyzer : UAudioAnalyzer {
// SynesthesiaSpectrumAnalyzer
	public USynesthesiaSpectrumAnalysisSettings Settings;
	public FOnSpectrumResults OnSpectrumResults;
	public FOnLatestSpectrumResults OnLatestSpectrumResults;
	public void GetCenterFrequencies(float InSampleRate,TArray<float> OutCenterFrequencies) {}
	public int GetNumCenterFrequencies() { return default; }
}
