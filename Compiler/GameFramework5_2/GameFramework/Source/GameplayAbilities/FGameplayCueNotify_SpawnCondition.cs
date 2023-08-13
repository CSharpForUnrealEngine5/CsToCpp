namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>FGameplayCueNotify_SpawnCondition</summary>
[CppInclude("GameplayCueNotifyTypes.h")]
public partial struct FGameplayCueNotify_SpawnCondition {
	public EGameplayCueNotify_LocallyControlledSource LocallyControlledSource;
	public EGameplayCueNotify_LocallyControlledPolicy LocallyControlledPolicy;
	public float ChanceToPlay;
	public TArray<EPhysicalSurface> AllowedSurfaceTypes;
	public TArray<EPhysicalSurface> RejectedSurfaceTypes;
}
