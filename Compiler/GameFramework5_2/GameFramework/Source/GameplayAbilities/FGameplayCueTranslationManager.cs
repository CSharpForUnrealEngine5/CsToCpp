#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>This is the struct that does the actual translation. It lives on the GameplayCueManager and encapsulates all translation logic.</summary>
[CppInclude("GameplayCueTranslator.h")]
public partial struct FGameplayCueTranslationManager {
	public TArray<FGameplayCueTranslatorNode> TranslationLUT;
	public TMap<string,FGameplayCueTranslatorNodeIndex> TranslationNameToIndexMap;
	public UGameplayTagsManager TagManager;
}
