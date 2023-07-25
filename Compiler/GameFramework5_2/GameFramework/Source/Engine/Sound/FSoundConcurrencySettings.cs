#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Sound/SoundConcurrency.h")]
public partial struct FSoundConcurrencySettings {
// SoundConcurrencySettings
	public int MaxCount;
	public bool bLimitToOwner;
	public bool bVolumeScaleCanRelease;
	public byte ResolutionRule;
	public float RetriggerTime;
	public float VolumeScale;
	public EConcurrencyVolumeScaleMode VolumeScaleMode;
	public float VolumeScaleAttackTime;
	public float VolumeScaleReleaseTime;
	public float VoiceStealReleaseTime;
}
