#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("LegacyCameraShake.h")]
///<summary>Defines oscillation of a single number.</summary>
public partial struct FFOscillator {
// FOscillator
	public float Amplitude;
	public float Frequency;
	public byte InitialOffset;
	public EOscillatorWaveform Waveform;
}
