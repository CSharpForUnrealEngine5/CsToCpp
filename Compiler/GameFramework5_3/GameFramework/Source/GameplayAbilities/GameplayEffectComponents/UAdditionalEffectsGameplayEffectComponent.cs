namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Add additional Gameplay Effects that attempt to activate under certain conditions (or no conditions)</summary>
[CppInclude("GameplayEffectComponents/AdditionalEffectsGameplayEffectComponent.h")]
public partial class UAdditionalEffectsGameplayEffectComponent : UGameplayEffectComponent {
	public static UClass StaticClass() {return default;}
	///<summary>This will copy all of the data (e.g. SetByCallerMagnitudes) from the GESpec that Applied this GameplayEffect to the new OnApplicationGameplayEffect Specs.</summary>
	public bool bOnApplicationCopyDataFromOriginalSpec;
	///<summary>Other gameplay effects that will be applied to the target of this effect if the owning effect applies</summary>
	public TArray<FConditionalGameplayEffect> OnApplicationGameplayEffects;
	///<summary>Effects to apply when this effect completes, regardless of how it ends</summary>
	public TArray<UClass> OnCompleteAlways;
	///<summary>Effects to apply when this effect expires naturally via its duration</summary>
	public TArray<UClass> OnCompleteNormal;
	///<summary>Effects to apply when this effect is made to expire prematurely (e.g. via a forced removal, clear tags, etc.)</summary>
	public TArray<UClass> OnCompletePrematurely;
}
