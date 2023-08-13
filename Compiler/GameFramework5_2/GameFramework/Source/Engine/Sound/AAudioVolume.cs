namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Sound/AudioVolume.h")]
public partial class AAudioVolume : AVolume {
	public static UClass StaticClass() {return default;}
	///<summary>Priority of this volume. In the case of overlapping volumes, the one with the highest priority</summary>
	public float Priority;
	///<summary>Whether this volume is currently enabled and able to affect sounds</summary>
	public bool bEnabled;
	///<summary>Reverb settings to use for this volume.</summary>
	public FReverbSettings Settings;
	///<summary>Impacts sounds that have &quot;Apply Ambient Volumes&quot; set to true in their Sound Class, based on whether the sound sources and the player are inside or outside the audio volume</summary>
	public FInteriorSettings AmbientZoneSettings;
	///<summary>Submix send settings to use for this volume. Allows audio to dynamically send to submixes based on source and listener locations relative to this volume.</summary>
	public TArray<FAudioVolumeSubmixSendSettings> SubmixSendSettings;
	///<summary>Submix effect chain override settings. Will override the effect chains on the given submixes when the conditions are met.</summary>
	public TArray<FAudioVolumeSubmixOverrideSettings> SubmixOverrideSettings;
	///<summary>SetPriority</summary>
	public void SetPriority(float NewPriority) {}
	///<summary>SetEnabled</summary>
	public void SetEnabled(bool bNewEnabled) {}
	///<summary>SetReverbSettings</summary>
	public void SetReverbSettings(FReverbSettings NewReverbSettings) {}
	///<summary>SetInteriorSettings</summary>
	public void SetInteriorSettings(FInteriorSettings NewInteriorSettings) {}
	///<summary>SetSubmixSendSettings</summary>
	public void SetSubmixSendSettings(TArray<FAudioVolumeSubmixSendSettings> NewSubmixSendSettings) {}
	///<summary>SetSubmixOverrideSettings</summary>
	public void SetSubmixOverrideSettings(TArray<FAudioVolumeSubmixOverrideSettings> NewSubmixOverrideSettings) {}
	///<summary>OnRep_bEnabled</summary>
	public virtual void OnRep_bEnabled() {}
}
