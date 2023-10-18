namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A Tag Container holds a collection of FGameplayTags, tags are included explicitly by adding them, and implicitly from adding child tags</summary>
[CppInclude("GameplayTagContainer.h")]
public partial struct FGameplayTagContainer {
	public TArray<FGameplayTag> GameplayTags;
	public TArray<FGameplayTag> ParentTags;
}
