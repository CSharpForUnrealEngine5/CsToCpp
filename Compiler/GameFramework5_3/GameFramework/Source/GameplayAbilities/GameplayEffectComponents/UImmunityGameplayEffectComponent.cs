namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Immunity is blocking the application of _other_ GameplayEffectSpecs.</summary>
[CppInclude("GameplayEffectComponents/ImmunityGameplayEffectComponent.h")]
public partial class UImmunityGameplayEffectComponent : UGameplayEffectComponent {
	public static UClass StaticClass() {return default;}
	///<summary>Grants immunity to GameplayEffects that match this query.</summary>
	public TArray<FGameplayEffectQuery> ImmunityQueries;
}
