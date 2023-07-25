#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("WaveOscillatorCameraShakePattern.h")]
///<summary>A camera shake that uses oscillations to move the camera.</summary>
public partial class UWaveOscillatorCameraShakePattern : USimpleCameraShakePattern {
// WaveOscillatorCameraShakePattern
	public float LocationAmplitudeMultiplier;
	public float LocationFrequencyMultiplier;
	public FWaveOscillator X;
	public FWaveOscillator Y;
	public FWaveOscillator Z;
	public float RotationAmplitudeMultiplier;
	public float RotationFrequencyMultiplier;
	public FWaveOscillator Pitch;
	public FWaveOscillator Yaw;
	public FWaveOscillator Roll;
	public FWaveOscillator FOV;
}
