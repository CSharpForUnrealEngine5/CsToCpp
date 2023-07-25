#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ConstantQNRT.h")]
///<summary>UConstantQNRTSettings</summary>
public partial class UConstantQNRTSettings : UAudioSynesthesiaNRTSettings {
// ConstantQNRTSettings
	public float StartingFrequency;
	public int NumBands;
	public float NumBandsPerOctave;
	public float AnalysisPeriod;
	public bool bDownmixToMono;
	public EConstantQFFTSizeEnum FFTSize;
	public EFFTWindowType WindowType;
	public EAudioSpectrumType SpectrumType;
	public float BandWidthStretch;
	public EConstantQNormalizationEnum CQTNormalization;
	public float NoiseFloorDb;
}
