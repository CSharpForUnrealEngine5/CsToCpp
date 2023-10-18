namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Handles granting Tags to the Target (sometimes referred to as the Owner) of the Gameplay Effect</summary>
[CppInclude("GameplayEffectComponents/TargetTagsGameplayEffectComponent.h")]
public partial class UTargetTagsGameplayEffectComponent : UGameplayEffectComponent {
	public static UClass StaticClass() {return default;}
	///<summary>These tags are applied (granted) to the target actor of the Gameplay Effect.  The Target would then &quot;own&quot; these Tags.</summary>
	public FInheritedTagContainer InheritableGrantedTagsContainer;
}
