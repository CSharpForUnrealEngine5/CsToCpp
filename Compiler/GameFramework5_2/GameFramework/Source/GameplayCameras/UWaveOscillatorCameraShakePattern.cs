namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A camera shake that uses oscillations to move the camera.</summary>
[CppInclude("WaveOscillatorCameraShakePattern.h")]
public partial class UWaveOscillatorCameraShakePattern : USimpleCameraShakePattern {
	public static UClass StaticClass() {return default;}
	///<summary>Amplitude multiplier for all location oscillation</summary>
	public float LocationAmplitudeMultiplier;
	///<summary>Frequency multiplier for all location oscillation</summary>
	public float LocationFrequencyMultiplier;
	///<summary>Oscillation in the X axis.</summary>
	public FWaveOscillator X;
	///<summary>Oscillation in the Y axis.</summary>
	public FWaveOscillator Y;
	///<summary>Oscillation in the Z axis.</summary>
	public FWaveOscillator Z;
	///<summary>Amplitude multiplier for all rotation oscillation</summary>
	public float RotationAmplitudeMultiplier;
	///<summary>Frequency multiplier for all rotation oscillation</summary>
	public float RotationFrequencyMultiplier;
	///<summary>Pitch oscillation.</summary>
	public FWaveOscillator Pitch;
	///<summary>Yaw oscillation.</summary>
	public FWaveOscillator Yaw;
	///<summary>Roll oscillation.</summary>
	public FWaveOscillator Roll;
	///<summary>FOV oscillation.</summary>
	public FWaveOscillator FOV;
}
