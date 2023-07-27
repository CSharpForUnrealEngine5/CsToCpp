#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("SourceEffects/SourceEffectEnvelopeFollower.h")]
public partial class USourceEffectEnvelopeFollowerPreset : USoundEffectSourcePreset {
// SourceEffectEnvelopeFollowerPreset
	public  void SetSettings(FSourceEffectEnvelopeFollowerSettings InSettings) {}
	public  void RegisterEnvelopeFollowerListener(UEnvelopeFollowerListener EnvelopeFollowerListener) {}
	public  void UnregisterEnvelopeFollowerListener(UEnvelopeFollowerListener EnvelopeFollowerListener) {}
	public FSourceEffectEnvelopeFollowerSettings Settings;
}
