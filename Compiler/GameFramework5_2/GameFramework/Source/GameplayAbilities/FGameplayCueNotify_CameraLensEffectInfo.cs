#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GameplayCueNotifyTypes.h")]
///<summary>FGameplayCueNotify_CameraLensEffectInfo</summary>
public partial struct FGameplayCueNotify_CameraLensEffectInfo {
// GameplayCueNotify_CameraLensEffectInfo
	public FGameplayCueNotify_SpawnCondition SpawnConditionOverride;
	public FGameplayCueNotify_PlacementInfo PlacementInfoOverride;
	public UClass CameraLensEffect;
	public bool bOverrideSpawnCondition;
	public bool bOverridePlacementInfo;
	public bool bPlayInWorld;
	public float WorldInnerRadius;
	public float WorldOuterRadius;
}
