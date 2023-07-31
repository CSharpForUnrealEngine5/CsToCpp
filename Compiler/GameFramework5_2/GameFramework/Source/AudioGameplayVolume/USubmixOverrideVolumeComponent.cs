#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>USubmixOverrideVolumeComponent - Audio Gameplay Volume component for submix effect chain overrides</summary>
[CppInclude("SubmixOverrideVolumeComponent.h")]
public partial class USubmixOverrideVolumeComponent : UAudioGameplayVolumeMutator {
	///<summary>SetSubmixOverrideSettings</summary>
	public  void SetSubmixOverrideSettings(TArray<FAudioVolumeSubmixOverrideSettings> NewSubmixOverrideSettings) {}
	///<summary>Submix effect chain override settings. Will override the effect chains on the given submixes</summary>
	public TArray<FAudioVolumeSubmixOverrideSettings> SubmixOverrideSettings;
}
