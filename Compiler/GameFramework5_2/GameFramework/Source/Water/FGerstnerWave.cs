#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GerstnerWaterWaves.h")]
///<summary>Raw wave parameters for one gerstner wave</summary>
public partial struct FGerstnerWave {
// GerstnerWave
	public float WaveLength;
	public float Amplitude;
	public float Steepness;
	public FVector Direction;
	public FVector2D WaveVector;
	public float WaveSpeed;
	public float WKA;
	public float Q;
	public float PhaseOffset;
}
