#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GerstnerWaterWaves.h")]
///<summary>Default implementation of a gerstner wave generator using a simple custom range based set of parameters to generate waves.</summary>
public partial class UGerstnerWaterWaveGeneratorSimple : UGerstnerWaterWaveGeneratorBase {
// GerstnerWaterWaveGeneratorSimple
	public int NumWaves;
	public int Seed;
	public float Randomness;
	public float MinWavelength;
	public float MaxWavelength;
	public float WavelengthFalloff;
	public float MinAmplitude;
	public float MaxAmplitude;
	public float AmplitudeFalloff;
	public float WindAngleDeg;
	public float DirectionAngularSpreadDeg;
	public float SmallWaveSteepness;
	public float LargeWaveSteepness;
	public float SteepnessFalloff;
}
