#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GameplayCueNotifyTypes.h")]
///<summary>FGameplayCueNotify_SoundInfo</summary>
public partial struct FGameplayCueNotify_SoundInfo {
// GameplayCueNotify_SoundInfo
	public FGameplayCueNotify_SpawnCondition SpawnConditionOverride;
	public FGameplayCueNotify_PlacementInfo PlacementInfoOverride;
	public USoundBase Sound;
	public USoundBase SoundCue;
	public float LoopingFadeOutDuration;
	public float LoopingFadeVolumeLevel;
	public FGameplayCueNotify_SoundParameterInterfaceInfo SoundParameterInterfaceInfo;
	public bool bOverrideSpawnCondition;
	public bool bOverridePlacementInfo;
	public bool bUseSoundParameterInterface;
}
