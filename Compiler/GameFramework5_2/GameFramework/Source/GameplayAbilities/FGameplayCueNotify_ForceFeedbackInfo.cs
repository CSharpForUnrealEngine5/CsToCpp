namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>FGameplayCueNotify_ForceFeedbackInfo</summary>
[CppInclude("GameplayCueNotifyTypes.h")]
public partial struct FGameplayCueNotify_ForceFeedbackInfo {
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
