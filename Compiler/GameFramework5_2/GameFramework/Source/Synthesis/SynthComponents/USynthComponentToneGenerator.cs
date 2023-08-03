#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("SynthComponents/SynthComponentToneGenerator.h")]
public partial class USynthComponentToneGenerator : USynthComponent {
	public static UClass StaticClass() {return default;}
	///<summary>The frequency (in hz) of the tone generator.</summary>
	public float Frequency;
	///<summary>The linear volume of the tone generator.</summary>
	public float Volume;
	///<summary>A distance attenuation curve to use to attenuate the audio.</summary>
	public FRuntimeFloatCurve DistanceAttenuationCurve;
	///<summary>A distance range over which to apply distance attenuation using the supplied curve.</summary>
	public FVector2D DistanceRange;
	///<summary>An attenuation, in decibels, to apply to the sound at max range.</summary>
	public float AttenuationDbAtMaxRange;
	///<summary>Sets the frequency of the tone generator</summary>
	public  void SetFrequency(float InFrequency) {}
	///<summary>Sets the volume of the tone generator</summary>
	public  void SetVolume(float InVolume) {}
}
