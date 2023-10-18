namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Applies a probablity to the application conditions of the Gameplay Effect.</summary>
[CppInclude("GameplayEffectComponents/ChanceToApplyGameplayEffectComponent.h")]
public partial class UChanceToApplyGameplayEffectComponent : UGameplayEffectComponent {
	public static UClass StaticClass() {return default;}
	///<summary>Probability that this gameplay effect will be applied to the target actor (0.0 for never, 1.0 for always)</summary>
	public FScalableFloat ChanceToApplyToTarget;
}
