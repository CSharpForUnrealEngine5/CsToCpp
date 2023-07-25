#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GameplayCueNotifyTypes.h")]
///<summary>FGameplayCueNotify_ParticleInfo</summary>
public partial struct FGameplayCueNotify_ParticleInfo {
// GameplayCueNotify_ParticleInfo
	public FGameplayCueNotify_SpawnCondition SpawnConditionOverride;
	public FGameplayCueNotify_PlacementInfo PlacementInfoOverride;
	public UNiagaraSystem NiagaraSystem;
	public bool bOverrideSpawnCondition;
	public bool bOverridePlacementInfo;
	public bool bCastShadow;
}
