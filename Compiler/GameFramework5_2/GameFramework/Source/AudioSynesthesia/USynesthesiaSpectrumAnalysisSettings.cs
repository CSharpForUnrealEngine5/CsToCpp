#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("SynesthesiaSpectrumAnalysis.h")]
///<summary>USynesthesiaSpectrumAnalysisSettings</summary>
public partial class USynesthesiaSpectrumAnalysisSettings : UAudioSynesthesiaSettings {
// SynesthesiaSpectrumAnalysisSettings
	public float AnalysisPeriod;
	public EFFTSize FFTSize;
	public EAudioSpectrumType SpectrumType;
	public EFFTWindowType WindowType;
	public bool bDownmixToMono;
}
