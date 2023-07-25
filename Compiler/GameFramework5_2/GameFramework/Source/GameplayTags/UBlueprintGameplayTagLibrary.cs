#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("BlueprintGameplayTagLibrary.h")]
public partial class UBlueprintGameplayTagLibrary : UBlueprintFunctionLibrary {
// BlueprintGameplayTagLibrary
	public bool MatchesTag(FGameplayTag TagOne,FGameplayTag TagTwo,bool bExactMatch) { return default; }
	public bool MatchesAnyTags(FGameplayTag TagOne,FGameplayTagContainer OtherContainer,bool bExactMatch) { return default; }
	public bool EqualEqual_GameplayTag(FGameplayTag A,FGameplayTag B) { return default; }
	public bool NotEqual_GameplayTag(FGameplayTag A,FGameplayTag B) { return default; }
	public bool IsGameplayTagValid(FGameplayTag GameplayTag) { return default; }
	public string GetTagName(FGameplayTag GameplayTag) { return default; }
	public FGameplayTag MakeLiteralGameplayTag(FGameplayTag Value) { return default; }
	public int GetNumGameplayTagsInContainer(FGameplayTagContainer TagContainer) { return default; }
	public bool HasTag(FGameplayTagContainer TagContainer,FGameplayTag Tag,bool bExactMatch) { return default; }
	public bool HasAnyTags(FGameplayTagContainer TagContainer,FGameplayTagContainer OtherContainer,bool bExactMatch) { return default; }
	public bool HasAllTags(FGameplayTagContainer TagContainer,FGameplayTagContainer OtherContainer,bool bExactMatch) { return default; }
	public bool IsTagQueryEmpty(FGameplayTagQuery TagQuery) { return default; }
	public bool DoesContainerMatchTagQuery(FGameplayTagContainer TagContainer,FGameplayTagQuery TagQuery) { return default; }
	public void GetAllActorsOfClassMatchingTagQuery(UObject WorldContextObject,UClass ActorClass,FGameplayTagQuery GameplayTagQuery,TArray<UObject> OutActors) {}
	public void AddGameplayTag(FGameplayTagContainer TagContainer,FGameplayTag Tag) {}
	public bool RemoveGameplayTag(FGameplayTagContainer TagContainer,FGameplayTag Tag) { return default; }
	public void AppendGameplayTagContainers(FGameplayTagContainer InOutTagContainer,FGameplayTagContainer InTagContainer) {}
	public bool EqualEqual_GameplayTagContainer(FGameplayTagContainer A,FGameplayTagContainer B) { return default; }
	public bool NotEqual_GameplayTagContainer(FGameplayTagContainer A,FGameplayTagContainer B) { return default; }
	public FGameplayTagContainer MakeLiteralGameplayTagContainer(FGameplayTagContainer Value) { return default; }
	public FGameplayTagContainer MakeGameplayTagContainerFromArray(TArray<FGameplayTag> GameplayTags) { return default; }
	public FGameplayTagContainer MakeGameplayTagContainerFromTag(FGameplayTag SingleTag) { return default; }
	public void BreakGameplayTagContainer(FGameplayTagContainer GameplayTagContainer,TArray<FGameplayTag> GameplayTags) {}
	public FGameplayTagQuery MakeGameplayTagQuery(FGameplayTagQuery TagQuery) { return default; }
	public bool HasAllMatchingGameplayTags(object /*TagContainerInterface*/ TagContainerInterface,FGameplayTagContainer OtherContainer) { return default; }
	public bool DoesTagAssetInterfaceHaveTag(object /*TagContainerInterface*/ TagContainerInterface,FGameplayTag Tag) { return default; }
	public bool NotEqual_TagTag(FGameplayTag A,string B) { return default; }
	public bool NotEqual_TagContainerTagContainer(FGameplayTagContainer A,string B) { return default; }
	public string GetDebugStringFromGameplayTagContainer(FGameplayTagContainer TagContainer) { return default; }
	public string GetDebugStringFromGameplayTag(FGameplayTag GameplayTag) { return default; }
}
