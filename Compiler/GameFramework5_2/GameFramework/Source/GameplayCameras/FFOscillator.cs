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
