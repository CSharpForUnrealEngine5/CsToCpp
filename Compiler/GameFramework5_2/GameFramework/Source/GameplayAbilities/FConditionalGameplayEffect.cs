#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GameplayEffect.h")]
///<summary>Struct for gameplay effects that apply only if another gameplay effect (or execution) was successfully applied.</summary>
public partial struct FConditionalGameplayEffect {
// ConditionalGameplayEffect
	public UClass EffectClass;
	public FGameplayTagContainer RequiredSourceTags;
}
