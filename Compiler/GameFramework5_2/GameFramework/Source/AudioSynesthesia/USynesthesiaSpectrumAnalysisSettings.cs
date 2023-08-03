#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>USynesthesiaSpectrumAnalysisSettings</summary>
[CppInclude("SynesthesiaSpectrumAnalysis.h")]
public partial class USynesthesiaSpectrumAnalysisSettings : UAudioSynesthesiaSettings {
	public static UClass StaticClass() {return default;}
	///<summary>Number of seconds between SynesthesiaSpectrumAnalysis measurements</summary>
	public float AnalysisPeriod;
	///<summary>Size of FFT.</summary>
	public EFFTSize FFTSize;
	///<summary>Type of spectrum to use.</summary>
	public EAudioSpectrumType SpectrumType;
	///<summary>Type of window to use.</summary>
	public EFFTWindowType WindowType;
	///<summary>If true, multichannel audio is downmixed to mono with equal amplitude scaling. If false, each channel gets its own FFT result.</summary>
	public bool bDownmixToMono;
}
