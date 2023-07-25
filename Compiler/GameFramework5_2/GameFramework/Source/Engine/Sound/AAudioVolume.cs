#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Sound/AudioVolume.h")]
public partial class AAudioVolume : AVolume {
// AudioVolume
	public float Priority;
	public bool bEnabled;
	public FReverbSettings Settings;
	public FInteriorSettings AmbientZoneSettings;
	public TArray<FAudioVolumeSubmixSendSettings> SubmixSendSettings;
	public TArray<FAudioVolumeSubmixOverrideSettings> SubmixOverrideSettings;
	public void SetPriority(float NewPriority) {}
	public void SetEnabled(bool bNewEnabled) {}
	public void SetReverbSettings(FReverbSettings NewReverbSettings) {}
	public void SetInteriorSettings(FInteriorSettings NewInteriorSettings) {}
	public void SetSubmixSendSettings(TArray<FAudioVolumeSubmixSendSettings> NewSubmixSendSettings) {}
	public void SetSubmixOverrideSettings(TArray<FAudioVolumeSubmixOverrideSettings> NewSubmixOverrideSettings) {}
	public void OnRep_bEnabled() {}
}
