namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Structure used to combine tags from different sources during effect execution</summary>
[CppInclude("GameplayEffectTypes.h")]
public partial struct FTagContainerAggregator {
	public FGameplayTagContainer CapturedActorTags;
	public FGameplayTagContainer CapturedSpecTags;
	public FGameplayTagContainer ScopedTags;
}
