#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("SubmixSendVolumeComponent.h")]
///<summary>USubmixSendVolumeComponent - Audio Gameplay Volume component for submix sends</summary>
public partial class USubmixSendVolumeComponent : UAudioGameplayVolumeMutator {
// SubmixSendVolumeComponent
	public  void SetSubmixSendSettings(TArray<FAudioVolumeSubmixSendSettings> NewSubmixSendSettings) {}
	public TArray<FAudioVolumeSubmixSendSettings> SubmixSendSettings;
}
