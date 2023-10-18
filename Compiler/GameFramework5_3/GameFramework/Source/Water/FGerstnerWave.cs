namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Raw wave parameters for one gerstner wave</summary>
[CppInclude("GerstnerWaterWaves.h")]
public partial struct FGerstnerWave {
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
