#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GerstnerWaterWaves.h")]
///<summary>Default implementation of a gerstner wave generator using known wave spectra from oceanology.</summary>
public partial class UGerstnerWaterWaveGeneratorSpectrum : UGerstnerWaterWaveGeneratorBase {
// GerstnerWaterWaveGeneratorSpectrum
	public EWaveSpectrumType SpectrumType;
	public TArray<FGerstnerWaveOctave> Octaves;
}
