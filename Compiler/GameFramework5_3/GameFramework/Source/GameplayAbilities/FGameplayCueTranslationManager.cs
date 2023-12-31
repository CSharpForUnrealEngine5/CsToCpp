namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>This is the struct that does the actual translation. It lives on the GameplayCueManager and encapsulates all translation logic.</summary>
[CppInclude("GameplayCueTranslator.h")]
public partial struct FGameplayCueTranslationManager {
	public TArray<FGameplayCueTranslatorNode> TranslationLUT;
	public TMap<FName,FGameplayCueTranslatorNodeIndex> TranslationNameToIndexMap;
	public UGameplayTagsManager TagManager;
}
