#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Sound/ReverbEffect.h")]
public partial class UReverbEffect : UObject {
// ReverbEffect
	public bool bBypassEarlyReflections;
	public float ReflectionsDelay;
	public float GainHF;
	public float ReflectionsGain;
	public bool bBypassLateReflections;
	public float LateDelay;
	public float DecayTime;
	public float Density;
	public float Diffusion;
	public float AirAbsorptionGainHF;
	public float DecayHFRatio;
	public float LateGain;
	public float Gain;
	public float RoomRolloffFactor;
	public bool bChanged;
}
