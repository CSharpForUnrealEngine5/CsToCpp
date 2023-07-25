#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Abilities/GameplayAbilityTypes.h")]
///<summary>Data about montages that were played locally (all montages in case of server. predictive montages in case of client). Never replicated directly.</summary>
public partial struct FGameplayAbilityLocalAnimMontage {
// GameplayAbilityLocalAnimMontage
	public UAnimMontage AnimMontage;
	public byte PlayInstanceId;
	public FPredictionKey PredictionKey;
	public TWeakObjectPtr<UGameplayAbility> AnimatingAbility;
}
