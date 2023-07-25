#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("SubmixEffects/SubmixEffectStereoToQuad.h")]
///<summary>Submix effect which sends stereo audio to quad (left surround and right surround) if the channel count is greater than 2.</summary>
public partial class USubmixEffectStereoToQuadPreset : USoundEffectSubmixPreset {
// SubmixEffectStereoToQuadPreset
	public void SetSettings(FSubmixEffectStereoToQuadSettings InSettings) {}
	public FSubmixEffectStereoToQuadSettings Settings;
}
