namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Default implementation of a gerstner wave generator using a simple custom range based set of parameters to generate waves.</summary>
[CppInclude("GerstnerWaterWaves.h")]
public partial class UGerstnerWaterWaveGeneratorSimple : UGerstnerWaterWaveGeneratorBase {
	public static UClass StaticClass() {return default;}
	///<summary>NumWaves</summary>
	public int NumWaves;
	///<summary>Seed</summary>
	public int Seed;
	///<summary>Randomness</summary>
	public float Randomness;
	///<summary>MinWavelength</summary>
	public float MinWavelength;
	///<summary>MaxWavelength</summary>
	public float MaxWavelength;
	///<summary>WavelengthFalloff</summary>
	public float WavelengthFalloff;
	///<summary>MinAmplitude</summary>
	public float MinAmplitude;
	///<summary>MaxAmplitude</summary>
	public float MaxAmplitude;
	///<summary>AmplitudeFalloff</summary>
	public float AmplitudeFalloff;
	///<summary>WindAngleDeg</summary>
	public float WindAngleDeg;
	///<summary>DirectionAngularSpreadDeg</summary>
	public float DirectionAngularSpreadDeg;
	///<summary>SmallWaveSteepness</summary>
	public float SmallWaveSteepness;
	///<summary>LargeWaveSteepness</summary>
	public float LargeWaveSteepness;
	///<summary>SteepnessFalloff</summary>
	public float SteepnessFalloff;
}
