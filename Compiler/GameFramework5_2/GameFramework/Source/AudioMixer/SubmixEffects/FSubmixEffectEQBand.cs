#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("SubmixEffects/AudioMixerSubmixEffectEQ.h")]
///<summary>A multiband EQ submix effect.</summary>
public partial struct FSubmixEffectEQBand {
// SubmixEffectEQBand
	public float Frequency;
	public float Bandwidth;
	public float GainDb;
	public bool bEnabled;
}
