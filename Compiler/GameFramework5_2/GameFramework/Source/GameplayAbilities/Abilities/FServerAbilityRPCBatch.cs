#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Abilities/GameplayAbilityTypes.h")]
///<summary>This struct holds state to batch server RPC calls: ServerTryActivateAbility, ServerSetReplicatedTargetData, ServerEndAbility.</summary>
public partial struct FServerAbilityRPCBatch {
// ServerAbilityRPCBatch
	public FGameplayAbilitySpecHandle AbilitySpecHandle;
	public FPredictionKey PredictionKey;
	public FGameplayAbilityTargetDataHandle TargetData;
	public bool InputPressed;
	public bool Ended;
	public bool Started;
}
