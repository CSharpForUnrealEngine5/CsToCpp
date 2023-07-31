#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>FGameplayCueNotify_CameraLensEffectInfo</summary>
[CppInclude("GameplayCueNotifyTypes.h")]
public partial struct FGameplayCueNotify_CameraLensEffectInfo {
	public FGameplayCueNotify_SpawnCondition SpawnConditionOverride;
	public FGameplayCueNotify_PlacementInfo PlacementInfoOverride;
	public UClass CameraLensEffect;
	public bool bOverrideSpawnCondition;
	public bool bOverridePlacementInfo;
	public bool bPlayInWorld;
	public float WorldInnerRadius;
	public float WorldOuterRadius;
}
