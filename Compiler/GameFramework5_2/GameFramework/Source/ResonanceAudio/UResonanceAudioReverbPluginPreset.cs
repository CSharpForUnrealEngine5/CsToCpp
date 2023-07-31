#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ResonanceAudioReverb.h")]
public partial class UResonanceAudioReverbPluginPreset : USoundEffectSubmixPreset {
	///<summary>Settings</summary>
	public FResonanceAudioReverbPluginSettings Settings;
	///<summary>Enables/disables Resonance Audio room effects</summary>
	public  void SetEnableRoomEffects(bool bInEnableRoomEffects) {}
	///<summary>Sets room position in 3D space</summary>
	public  void SetRoomPosition(FVector InPosition) {}
	///<summary>Sets room rotation in 3D space</summary>
	public  void SetRoomRotation(FQuat InRotation) {}
	///<summary>Sets room dimensions in 3D space</summary>
	public  void SetRoomDimensions(FVector InDimensions) {}
	///<summary>Sets Resonance Audio room&#39;s acoustic materials</summary>
	public  void SetRoomMaterials(TArray<ERaMaterialName> InMaterials) {}
	///<summary>Sets early reflections gain multiplier</summary>
	public  void SetReflectionScalar(float InReflectionScalar) {}
	///<summary>Sets reverb gain multiplier</summary>
	public  void SetReverbGain(float InReverbGain) {}
	///<summary>Adjusts the reverberation time across all frequency bands by multiplying the computed values by this factor.</summary>
	public  void SetReverbTimeModifier(float InReverbTimeModifier) {}
	///<summary>Increases high frequency reverberation times when positive, decreases when negative.</summary>
	public  void SetReverbBrightness(float InReverbBrightness) {}
}
