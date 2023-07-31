#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>The results of the loudness analyis.</summary>
[CppInclude("Loudness.h")]
public partial struct FLoudnessResults {
	public float Loudness;
	public float NormalizedLoudness;
	public float PerceptualEnergy;
	public float TimeSeconds;
}
