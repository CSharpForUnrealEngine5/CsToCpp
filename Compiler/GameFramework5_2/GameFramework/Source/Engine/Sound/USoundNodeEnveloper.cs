#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Allows manipulation of volume and pitch over a set time period</summary>
[CppInclude("Sound/SoundNodeEnveloper.h")]
public partial class USoundNodeEnveloper : USoundNode {
	public static UClass StaticClass() {return default;}
	///<summary>The time in seconds where the envelope&#39;s loop begins.</summary>
	public float LoopStart;
	///<summary>The time in seconds where the envelope&#39;s loop ends.</summary>
	public float LoopEnd;
	///<summary>The time in seconds it takes the evelope to fade out after the last loop is completed.</summary>
	public float DurationAfterLoop;
	///<summary>The number of times the envelope should loop if looping is enabled and the envelope is not set to loop indefinitely.</summary>
	public int LoopCount;
	///<summary>If enabled, the envelope will continue to loop indefenitely regardless of the Loop Count value.</summary>
	public bool bLoopIndefinitely;
	///<summary>If enabled, the envelope will loop using the loop settings.</summary>
	public bool bLoop;
	///<summary>VolumeInterpCurve_DEPRECATED</summary>
	public UDistributionFloatConstantCurve VolumeInterpCurve_DEPRECATED;
	///<summary>PitchInterpCurve_DEPRECATED</summary>
	public UDistributionFloatConstantCurve PitchInterpCurve_DEPRECATED;
	///<summary>The distribution defining the volume envelope.</summary>
	public FRuntimeFloatCurve VolumeCurve;
	///<summary>The distribution defining the pitch envelope.</summary>
	public FRuntimeFloatCurve PitchCurve;
	///<summary>The lower bound of pitch (1.0 is no change)</summary>
	public float PitchMin;
	///<summary>The upper bound of pitch (1.0 is no change)</summary>
	public float PitchMax;
	///<summary>The lower bound of volume (1.0 is no change)</summary>
	public float VolumeMin;
	///<summary>The upper bound of volume (1.0 is no change)</summary>
	public float VolumeMax;
}
