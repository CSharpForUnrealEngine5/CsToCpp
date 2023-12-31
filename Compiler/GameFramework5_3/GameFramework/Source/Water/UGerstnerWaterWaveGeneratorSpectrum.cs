namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Default implementation of a gerstner wave generator using known wave spectra from oceanology.</summary>
[CppInclude("GerstnerWaterWaves.h")]
public partial class UGerstnerWaterWaveGeneratorSpectrum : UGerstnerWaterWaveGeneratorBase {
	public static UClass StaticClass() {return default;}
	///<summary>SpectrumType</summary>
	public EWaveSpectrumType SpectrumType;
	///<summary>Octaves</summary>
	public TArray<FGerstnerWaveOctave> Octaves;
}
