#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ResonanceAudioReverb.h")]
public partial class UResonanceAudioReverbPluginPreset : USoundEffectSubmixPreset {
// ResonanceAudioReverbPluginPreset
	public FResonanceAudioReverbPluginSettings Settings;
	public void SetEnableRoomEffects(bool bInEnableRoomEffects) {}
	public void SetRoomPosition(FVector InPosition) {}
	public void SetRoomRotation(FQuat InRotation) {}
	public void SetRoomDimensions(FVector InDimensions) {}
	public void SetRoomMaterials(TArray<ERaMaterialName> InMaterials) {}
	public void SetReflectionScalar(float InReflectionScalar) {}
	public void SetReverbGain(float InReverbGain) {}
	public void SetReverbTimeModifier(float InReverbTimeModifier) {}
	public void SetReverbBrightness(float InReverbBrightness) {}
}
