#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Computes doppler pitch shift</summary>
[CppInclude("Sound/SoundNodeDoppler.h")]
public partial class USoundNodeDoppler : USoundNode {
	///<summary>How much to scale the doppler shift (1.0 is normal).</summary>
	public float DopplerIntensity;
	///<summary>Whether or not to do a smooth interp to our doppler</summary>
	public bool bUseSmoothing;
	///<summary>Speed at which to interp pitch scale</summary>
	public float SmoothingInterpSpeed;
}
