#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GameplayTagContainer.h")]
///<summary>A Tag Container holds a collection of FGameplayTags, tags are included explicitly by adding them, and implicitly from adding child tags</summary>
public partial struct FGameplayTagContainer {
// GameplayTagContainer
	public TArray<FGameplayTag> GameplayTags;
	public TArray<FGameplayTag> ParentTags;
}
