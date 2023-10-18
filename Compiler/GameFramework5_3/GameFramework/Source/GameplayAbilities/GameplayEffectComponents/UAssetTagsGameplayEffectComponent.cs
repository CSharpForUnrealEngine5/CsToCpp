namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>These are tags that the Gameplay Effect Asset itself &#39;has&#39; (owns). These do _not_ transfer to any Actors</summary>
[CppInclude("GameplayEffectComponents/AssetTagsGameplayEffectComponent.h")]
public partial class UAssetTagsGameplayEffectComponent : UGameplayEffectComponent {
	public static UClass StaticClass() {return default;}
	///<summary>The GameplayEffect&#39;s Tags: tags the the GE *has* and DOES NOT give to the actor.</summary>
	public FInheritedTagContainer InheritableAssetTags;
}
