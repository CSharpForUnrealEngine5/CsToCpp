#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PerlinNoiseCameraShakePattern.h")]
///<summary>A camera shake that uses Perlin noise to shake the camera.</summary>
public partial class UPerlinNoiseCameraShakePattern : USimpleCameraShakePattern {
// PerlinNoiseCameraShakePattern
	public float LocationAmplitudeMultiplier;
	public float LocationFrequencyMultiplier;
	public FPerlinNoiseShaker X;
	public FPerlinNoiseShaker Y;
	public FPerlinNoiseShaker Z;
	public float RotationAmplitudeMultiplier;
	public float RotationFrequencyMultiplier;
	public FPerlinNoiseShaker Pitch;
	public FPerlinNoiseShaker Yaw;
	public FPerlinNoiseShaker Roll;
	public FPerlinNoiseShaker FOV;
}
