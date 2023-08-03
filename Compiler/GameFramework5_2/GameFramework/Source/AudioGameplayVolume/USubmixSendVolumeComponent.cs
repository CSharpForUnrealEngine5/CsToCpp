#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>USubmixSendVolumeComponent - Audio Gameplay Volume component for submix sends</summary>
[CppInclude("SubmixSendVolumeComponent.h")]
public partial class USubmixSendVolumeComponent : UAudioGameplayVolumeMutator {
	public static UClass StaticClass() {return default;}
	///<summary>SetSubmixSendSettings</summary>
	public  void SetSubmixSendSettings(TArray<FAudioVolumeSubmixSendSettings> NewSubmixSendSettings) {}
	///<summary>Submix send settings to use for this component. Allows audio to dynamically send to submixes based on source and listener locations (relative to parent volume.)</summary>
	public TArray<FAudioVolumeSubmixSendSettings> SubmixSendSettings;
}
