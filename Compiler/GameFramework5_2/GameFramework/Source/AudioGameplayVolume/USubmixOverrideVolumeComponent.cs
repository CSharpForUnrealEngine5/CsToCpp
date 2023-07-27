#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("SubmixOverrideVolumeComponent.h")]
///<summary>USubmixOverrideVolumeComponent - Audio Gameplay Volume component for submix effect chain overrides</summary>
public partial class USubmixOverrideVolumeComponent : UAudioGameplayVolumeMutator {
// SubmixOverrideVolumeComponent
	public  void SetSubmixOverrideSettings(TArray<FAudioVolumeSubmixOverrideSettings> NewSubmixOverrideSettings) {}
	public TArray<FAudioVolumeSubmixOverrideSettings> SubmixOverrideSettings;
}
