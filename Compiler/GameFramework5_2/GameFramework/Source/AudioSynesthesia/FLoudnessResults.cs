#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Loudness.h")]
///<summary>The results of the loudness analyis.</summary>
public partial struct FLoudnessResults {
// LoudnessResults
	public float Loudness;
	public float NormalizedLoudness;
	public float PerceptualEnergy;
	public float TimeSeconds;
}
