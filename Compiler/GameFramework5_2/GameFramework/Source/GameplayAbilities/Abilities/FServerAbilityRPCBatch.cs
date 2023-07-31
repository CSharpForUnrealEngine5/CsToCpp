#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>This struct holds state to batch server RPC calls: ServerTryActivateAbility, ServerSetReplicatedTargetData, ServerEndAbility.</summary>
[CppInclude("Abilities/GameplayAbilityTypes.h")]
public partial struct FServerAbilityRPCBatch {
	public FGameplayAbilitySpecHandle AbilitySpecHandle;
	public FPredictionKey PredictionKey;
	public FGameplayAbilityTargetDataHandle TargetData;
	public bool InputPressed;
	public bool Ended;
	public bool Started;
}
