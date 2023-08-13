namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Encapsulate require and ignore tags</summary>
[CppInclude("GameplayEffectTypes.h")]
public partial struct FGameplayTagRequirements {
	public FGameplayTagContainer RequireTags;
	public FGameplayTagContainer IgnoreTags;
}
