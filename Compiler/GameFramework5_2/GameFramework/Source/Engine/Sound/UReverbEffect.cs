#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Sound/ReverbEffect.h")]
public partial class UReverbEffect : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Bypasses early reflections</summary>
	public bool bBypassEarlyReflections;
	///<summary>Reflections Delay - 0.0 &lt; 0.007 &lt; 0.3 Seconds - the time between the listener receiving the direct path sound and the first reflection</summary>
	public float ReflectionsDelay;
	///<summary>Reverb Gain High Frequency - 0.0 &lt; 0.89 &lt; 1.0 - attenuates the high frequency reflected sound</summary>
	public float GainHF;
	///<summary>Reflections Gain - 0.0 &lt; 0.05 &lt; 3.16 - controls the amount of initial reflections</summary>
	public float ReflectionsGain;
	///<summary>Bypasses late reflections.</summary>
	public bool bBypassLateReflections;
	///<summary>Late Reverb Delay - 0.0 &lt; 0.011 &lt; 0.1 Seconds - time difference between late reverb and first reflections</summary>
	public float LateDelay;
	///<summary>Decay Time - 0.1 &lt; 1.49 &lt; 20.0 Seconds - larger is more reverb</summary>
	public float DecayTime;
	///<summary>Density - 0.0 &lt; 1.0 &lt; 1.0 - Coloration of the late reverb - lower value is more grainy</summary>
	public float Density;
	///<summary>Diffusion - 0.0 &lt; 1.0 &lt; 1.0 - Echo density in the reverberation decay - lower is more grainy</summary>
	public float Diffusion;
	///<summary>Air Absorption - 0.0 &lt; 0.994 &lt; 1.0 - lower value means more absorption</summary>
	public float AirAbsorptionGainHF;
	///<summary>Decay High Frequency Ratio - 0.1 &lt; 0.83 &lt; 2.0 - how much the quicker or slower the high frequencies decay relative to the lower frequencies.</summary>
	public float DecayHFRatio;
	///<summary>Late Reverb Gain - 0.0 &lt; 1.26 &lt; 10.0 - gain of the late reverb</summary>
	public float LateGain;
	///<summary>Reverb Gain - 0.0 &lt; 0.32 &lt; 1.0 - overall reverb gain - master volume control</summary>
	public float Gain;
	///<summary>RoomRolloffFactor</summary>
	public float RoomRolloffFactor;
	///<summary>Transient property used to trigger real-time updates of the reverb for real-time editor previewing</summary>
	public bool bChanged;
}
