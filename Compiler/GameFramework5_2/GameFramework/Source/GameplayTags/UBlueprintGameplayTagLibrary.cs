#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("BlueprintGameplayTagLibrary.h")]
public partial class UBlueprintGameplayTagLibrary : UBlueprintFunctionLibrary {
// BlueprintGameplayTagLibrary
	public static bool MatchesTag(FGameplayTag TagOne,FGameplayTag TagTwo,bool bExactMatch) { return default; }
	public static bool MatchesAnyTags(FGameplayTag TagOne,FGameplayTagContainer OtherContainer,bool bExactMatch) { return default; }
	public static bool EqualEqual_GameplayTag(FGameplayTag A,FGameplayTag B) { return default; }
	public static bool NotEqual_GameplayTag(FGameplayTag A,FGameplayTag B) { return default; }
	public static bool IsGameplayTagValid(FGameplayTag GameplayTag) { return default; }
	public static string GetTagName(FGameplayTag GameplayTag) { return default; }
	public static FGameplayTag MakeLiteralGameplayTag(FGameplayTag Value) { return default; }
	public static int GetNumGameplayTagsInContainer(FGameplayTagContainer TagContainer) { return default; }
	public static bool HasTag(FGameplayTagContainer TagContainer,FGameplayTag Tag,bool bExactMatch) { return default; }
	public static bool HasAnyTags(FGameplayTagContainer TagContainer,FGameplayTagContainer OtherContainer,bool bExactMatch) { return default; }
	public static bool HasAllTags(FGameplayTagContainer TagContainer,FGameplayTagContainer OtherContainer,bool bExactMatch) { return default; }
	public static bool IsTagQueryEmpty(FGameplayTagQuery TagQuery) { return default; }
	public static bool DoesContainerMatchTagQuery(FGameplayTagContainer TagContainer,FGameplayTagQuery TagQuery) { return default; }
	public static void GetAllActorsOfClassMatchingTagQuery(UObject WorldContextObject,UClass ActorClass,FGameplayTagQuery GameplayTagQuery,TArray<AActor> OutActors) {}
	public static void AddGameplayTag(FGameplayTagContainer TagContainer,FGameplayTag Tag) {}
	public static bool RemoveGameplayTag(FGameplayTagContainer TagContainer,FGameplayTag Tag) { return default; }
	public static void AppendGameplayTagContainers(FGameplayTagContainer InOutTagContainer,FGameplayTagContainer InTagContainer) {}
	public static bool EqualEqual_GameplayTagContainer(FGameplayTagContainer A,FGameplayTagContainer B) { return default; }
	public static bool NotEqual_GameplayTagContainer(FGameplayTagContainer A,FGameplayTagContainer B) { return default; }
	public static FGameplayTagContainer MakeLiteralGameplayTagContainer(FGameplayTagContainer Value) { return default; }
	public static FGameplayTagContainer MakeGameplayTagContainerFromArray(TArray<FGameplayTag> GameplayTags) { return default; }
	public static FGameplayTagContainer MakeGameplayTagContainerFromTag(FGameplayTag SingleTag) { return default; }
	public static void BreakGameplayTagContainer(FGameplayTagContainer GameplayTagContainer,TArray<FGameplayTag> GameplayTags) {}
	public static FGameplayTagQuery MakeGameplayTagQuery(FGameplayTagQuery TagQuery) { return default; }
	public static bool HasAllMatchingGameplayTags(object /*TagContainerInterface*/ TagContainerInterface,FGameplayTagContainer OtherContainer) { return default; }
	public static bool DoesTagAssetInterfaceHaveTag(object /*TagContainerInterface*/ TagContainerInterface,FGameplayTag Tag) { return default; }
	public static bool NotEqual_TagTag(FGameplayTag A,string B) { return default; }
	public static bool NotEqual_TagContainerTagContainer(FGameplayTagContainer A,string B) { return default; }
	public static string GetDebugStringFromGameplayTagContainer(FGameplayTagContainer TagContainer) { return default; }
	public static string GetDebugStringFromGameplayTag(FGameplayTag GameplayTag) { return default; }
}
