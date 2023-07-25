#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GameplayCueNotifyTypes.h")]
///<summary>FGameplayCueNotify_SpawnCondition</summary>
public partial struct FGameplayCueNotify_SpawnCondition {
// GameplayCueNotify_SpawnCondition
	public EGameplayCueNotify_LocallyControlledSource LocallyControlledSource;
	public EGameplayCueNotify_LocallyControlledPolicy LocallyControlledPolicy;
	public float ChanceToPlay;
	public TArray<byte> AllowedSurfaceTypes;
	public TArray<byte> RejectedSurfaceTypes;
}
