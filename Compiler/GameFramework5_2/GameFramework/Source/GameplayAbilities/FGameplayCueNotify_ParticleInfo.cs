#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>FGameplayCueNotify_ParticleInfo</summary>
[CppInclude("GameplayCueNotifyTypes.h")]
public partial struct FGameplayCueNotify_ParticleInfo {
	public FGameplayCueNotify_SpawnCondition SpawnConditionOverride;
	public FGameplayCueNotify_PlacementInfo PlacementInfoOverride;
	public UNiagaraSystem NiagaraSystem;
	public bool bOverrideSpawnCondition;
	public bool bOverridePlacementInfo;
	public bool bCastShadow;
}
