#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A node in our translation table/graph. The node represents an actual gameplaytag or a possible gameplay tag, with links to what it can be translated into.</summary>
[CppInclude("GameplayCueTranslator.h")]
public partial struct FGameplayCueTranslatorNode {
	public TArray<FGameplayCueTranslationLink> Links;
	public FGameplayCueTranslatorNodeIndex CachedIndex;
	public FGameplayTag CachedGameplayTag;
	public string CachedGameplayTagName;
}
