#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>UConstantQNRTSettings</summary>
[CppInclude("ConstantQNRT.h")]
public partial class UConstantQNRTSettings : UAudioSynesthesiaNRTSettings {
	public static UClass StaticClass() {return default;}
	///<summary>Starting frequency for first bin of CQT</summary>
	public float StartingFrequency;
	///<summary>Total number of resulting constant Q bands.</summary>
	public int NumBands;
	///<summary>Number of bands within an octave.</summary>
	public float NumBandsPerOctave;
	///<summary>Number of seconds between cqt measurements</summary>
	public float AnalysisPeriod;
	///<summary>If true, multichannel audio is downmixed to mono with equal amplitude scaling. If false, each channel gets it&#39;s own CQT result.</summary>
	public bool bDownmixToMono;
	///<summary>Size of FFT.</summary>
	public EConstantQFFTSizeEnum FFTSize;
	///<summary>Type of window to be applied to input audio</summary>
	public EFFTWindowType WindowType;
	///<summary>Type of spectrum to use.</summary>
	public EAudioSpectrumType SpectrumType;
	///<summary>Stretching factor to control overlap of adjacent bands.</summary>
	public float BandWidthStretch;
	///<summary>Normalization scheme used to generate band windows.</summary>
	public EConstantQNormalizationEnum CQTNormalization;
	///<summary>Noise floor to use when normalizing CQT</summary>
	public float NoiseFloorDb;
}
