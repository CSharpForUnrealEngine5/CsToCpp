#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Defines oscillation of a single number.</summary>
[CppInclude("LegacyCameraShake.h")]
public partial struct FFOscillator {
	public float Amplitude;
	public float Frequency;
	public EInitialOscillatorOffset InitialOffset;
	public EOscillatorWaveform Waveform;
}
