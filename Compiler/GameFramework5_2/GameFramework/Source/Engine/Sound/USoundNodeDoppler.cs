#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Sound/SoundNodeDoppler.h")]
///<summary>Computes doppler pitch shift</summary>
public partial class USoundNodeDoppler : USoundNode {
// SoundNodeDoppler
	public float DopplerIntensity;
	public bool bUseSmoothing;
	public float SmoothingInterpSpeed;
}
