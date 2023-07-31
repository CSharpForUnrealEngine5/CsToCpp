#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A multiband EQ submix effect.</summary>
[CppInclude("SubmixEffects/AudioMixerSubmixEffectEQ.h")]
public partial struct FSubmixEffectEQBand {
	public float Frequency;
	public float Bandwidth;
	public float GainDb;
	public bool bEnabled;
}
