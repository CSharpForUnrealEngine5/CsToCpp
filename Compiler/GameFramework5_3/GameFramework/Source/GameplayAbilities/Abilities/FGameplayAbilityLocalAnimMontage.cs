namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Data about montages that were played locally (all montages in case of server. predictive montages in case of client). Never replicated directly.</summary>
[CppInclude("Abilities/GameplayAbilityTypes.h")]
public partial struct FGameplayAbilityLocalAnimMontage {
	public UAnimMontage AnimMontage;
	public byte PlayInstanceId;
	public FPredictionKey PredictionKey;
	public TWeakObjectPtr<UGameplayAbility> AnimatingAbility;
}
