#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Struct for gameplay effects that apply only if another gameplay effect (or execution) was successfully applied.</summary>
[CppInclude("GameplayEffect.h")]
public partial struct FConditionalGameplayEffect {
	public UClass EffectClass;
	public FGameplayTagContainer RequiredSourceTags;
}
