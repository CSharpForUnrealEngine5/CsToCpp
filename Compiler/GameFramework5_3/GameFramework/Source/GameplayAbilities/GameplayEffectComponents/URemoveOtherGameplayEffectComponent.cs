namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Remove other Gameplay Effects based on certain conditions</summary>
[CppInclude("GameplayEffectComponents/RemoveOtherGameplayEffectComponent.h")]
public partial class URemoveOtherGameplayEffectComponent : UGameplayEffectComponent {
	public static UClass StaticClass() {return default;}
	///<summary>On Application of the owning Gameplay Effect, any Active GameplayEffects that *match* these queries will be removed.</summary>
	public TArray<FGameplayEffectQuery> RemoveGameplayEffectQueries;
}
