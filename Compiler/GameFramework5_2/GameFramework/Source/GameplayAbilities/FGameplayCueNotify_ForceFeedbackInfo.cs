#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GameplayCueNotifyTypes.h")]
///<summary>FGameplayCueNotify_ForceFeedbackInfo</summary>
public partial struct FGameplayCueNotify_ForceFeedbackInfo {
// GameplayCueNotify_ForceFeedbackInfo
	public FGameplayCueNotify_SpawnCondition SpawnConditionOverride;
	public FGameplayCueNotify_PlacementInfo PlacementInfoOverride;
	public UForceFeedbackEffect ForceFeedbackEffect;
	public string ForceFeedbackTag;
	public bool bIsLooping;
	public bool bOverrideSpawnCondition;
	public bool bOverridePlacementInfo;
	public bool bPlayInWorld;
	public float WorldIntensity;
	public UForceFeedbackAttenuation WorldAttenuation;
}
