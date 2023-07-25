#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Sound/SoundNodeEnveloper.h")]
///<summary>Allows manipulation of volume and pitch over a set time period</summary>
public partial class USoundNodeEnveloper : USoundNode {
// SoundNodeEnveloper
	public float LoopStart;
	public float LoopEnd;
	public float DurationAfterLoop;
	public int LoopCount;
	public bool bLoopIndefinitely;
	public bool bLoop;
	public UDistributionFloatConstantCurve VolumeInterpCurve_DEPRECATED;
	public UDistributionFloatConstantCurve PitchInterpCurve_DEPRECATED;
	public FRuntimeFloatCurve VolumeCurve;
	public FRuntimeFloatCurve PitchCurve;
	public float PitchMin;
	public float PitchMax;
	public float VolumeMin;
	public float VolumeMax;
}
