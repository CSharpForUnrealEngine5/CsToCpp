#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("SynthComponents/SynthComponentToneGenerator.h")]
public partial class USynthComponentToneGenerator : USynthComponent {
// SynthComponentToneGenerator
	public float Frequency;
	public float Volume;
	public FRuntimeFloatCurve DistanceAttenuationCurve;
	public FVector2D DistanceRange;
	public float AttenuationDbAtMaxRange;
	public  void SetFrequency(float InFrequency) {}
	public  void SetVolume(float InVolume) {}
}
