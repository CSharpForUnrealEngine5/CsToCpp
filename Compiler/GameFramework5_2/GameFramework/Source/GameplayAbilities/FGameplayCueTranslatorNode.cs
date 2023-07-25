#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GameplayCueTranslator.h")]
///<summary>A node in our translation table/graph. The node represents an actual gameplaytag or a possible gameplay tag, with links to what it can be translated into.</summary>
public partial struct FGameplayCueTranslatorNode {
// GameplayCueTranslatorNode
	public TArray<FGameplayCueTranslationLink> Links;
	public FGameplayCueTranslatorNodeIndex CachedIndex;
	public FGameplayTag CachedGameplayTag;
	public string CachedGameplayTagName;
}
