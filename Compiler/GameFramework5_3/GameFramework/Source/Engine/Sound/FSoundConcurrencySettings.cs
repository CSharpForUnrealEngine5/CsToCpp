namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Sound/SoundConcurrency.h")]
public partial struct FSoundConcurrencySettings {
	public int MaxCount;
	public bool bLimitToOwner;
	public bool bVolumeScaleCanRelease;
	public EMaxConcurrentResolutionRule ResolutionRule;
	public float RetriggerTime;
	public float VolumeScale;
	public EConcurrencyVolumeScaleMode VolumeScaleMode;
	public float VolumeScaleAttackTime;
	public float VolumeScaleReleaseTime;
	public float VoiceStealReleaseTime;
}
