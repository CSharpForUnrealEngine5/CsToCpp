#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GameplayEffectTypes.h")]
///<summary>Structure used to combine tags from different sources during effect execution</summary>
public partial struct FTagContainerAggregator {
// TagContainerAggregator
	public FGameplayTagContainer CapturedActorTags;
	public FGameplayTagContainer CapturedSpecTags;
	public FGameplayTagContainer ScopedTags;
}
