namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A camera shake that uses Perlin noise to shake the camera.</summary>
[CppInclude("PerlinNoiseCameraShakePattern.h")]
public partial class UPerlinNoiseCameraShakePattern : USimpleCameraShakePattern {
	public static UClass StaticClass() {return default;}
	///<summary>Amplitude multiplier for all location shake</summary>
	public float LocationAmplitudeMultiplier;
	///<summary>Frequency multiplier for all location shake</summary>
	public float LocationFrequencyMultiplier;
	///<summary>Shake in the X axis.</summary>
	public FPerlinNoiseShaker X;
	///<summary>Shake in the Y axis.</summary>
	public FPerlinNoiseShaker Y;
	///<summary>Shake in the Z axis.</summary>
	public FPerlinNoiseShaker Z;
	///<summary>Amplitude multiplier for all rotation shake</summary>
	public float RotationAmplitudeMultiplier;
	///<summary>Frequency multiplier for all rotation shake</summary>
	public float RotationFrequencyMultiplier;
	///<summary>Pitch shake.</summary>
	public FPerlinNoiseShaker Pitch;
	///<summary>Yaw shake.</summary>
	public FPerlinNoiseShaker Yaw;
	///<summary>Roll shake.</summary>
	public FPerlinNoiseShaker Roll;
	///<summary>FOV shake.</summary>
	public FPerlinNoiseShaker FOV;
}
