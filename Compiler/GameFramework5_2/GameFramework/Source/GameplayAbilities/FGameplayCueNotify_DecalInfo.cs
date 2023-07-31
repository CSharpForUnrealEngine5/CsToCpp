#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>FGameplayCueNotify_DecalInfo</summary>
[CppInclude("GameplayCueNotifyTypes.h")]
public partial struct FGameplayCueNotify_DecalInfo {
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
