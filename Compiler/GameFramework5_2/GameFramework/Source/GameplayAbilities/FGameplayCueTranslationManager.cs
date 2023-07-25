#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GameplayCueTranslator.h")]
///<summary>This is the struct that does the actual translation. It lives on the GameplayCueManager and encapsulates all translation logic.</summary>
public partial struct FGameplayCueTranslationManager {
// GameplayCueTranslationManager
	public TArray<FGameplayCueTranslatorNode> TranslationLUT;
	public TMap<string,FGameplayCueTranslatorNodeIndex> TranslationNameToIndexMap;
	public UGameplayTagsManager TagManager;
}
