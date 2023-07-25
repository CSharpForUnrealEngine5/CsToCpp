#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GameplayCueNotifyTypes.h")]
///<summary>FGameplayCueNotify_DecalInfo</summary>
public partial struct FGameplayCueNotify_DecalInfo {
// GameplayCueNotify_DecalInfo
	public FGameplayCueNotify_SpawnCondition SpawnConditionOverride;
	public FGameplayCueNotify_PlacementInfo PlacementInfoOverride;
	public UMaterialInterface DecalMaterial;
	public FVector DecalSize;
	public bool bOverrideSpawnCondition;
	public bool bOverridePlacementInfo;
	public bool bOverrideFadeOut;
	public float FadeOutStartDelay;
	public float FadeOutDuration;
}
