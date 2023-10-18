namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Handles blocking the activation of Gameplay Abilities based on Gameplay Tags for the Target actor of the owner Gameplay Effect</summary>
[CppInclude("GameplayEffectComponents/BlockAbilityTagsGameplayEffectComponent.h")]
public partial class UBlockAbilityTagsGameplayEffectComponent : UGameplayEffectComponent {
	public static UClass StaticClass() {return default;}
	///<summary>These tags are applied to the target actor of the Gameplay Effect.  Blocked Ability Tags prevent Gameplay Abilities with these tags from executing.</summary>
	public FInheritedTagContainer InheritableBlockedAbilityTagsContainer;
}
