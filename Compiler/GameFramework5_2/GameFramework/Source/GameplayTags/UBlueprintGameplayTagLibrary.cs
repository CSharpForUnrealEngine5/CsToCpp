#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("BlueprintGameplayTagLibrary.h")]
public partial class UBlueprintGameplayTagLibrary : UBlueprintFunctionLibrary {
	public static UClass StaticClass() {return default;}
	///<summary>Determine if TagOne matches against TagTwo</summary>
	public static bool MatchesTag(FGameplayTag TagOne,FGameplayTag TagTwo,bool bExactMatch) { return default; }
	///<summary>Determine if TagOne matches against any tag in OtherContainer</summary>
	public static bool MatchesAnyTags(FGameplayTag TagOne,FGameplayTagContainer OtherContainer,bool bExactMatch) { return default; }
	///<summary>Returns true if the values are equal (A == B)</summary>
	public static bool EqualEqual_GameplayTag(FGameplayTag A,FGameplayTag B) { return default; }
	///<summary>Returns true if the values are not equal (A != B)</summary>
	public static bool NotEqual_GameplayTag(FGameplayTag A,FGameplayTag B) { return default; }
	///<summary>Returns true if the passed in gameplay tag is non-null</summary>
	public static bool IsGameplayTagValid(FGameplayTag GameplayTag) { return default; }
	///<summary>Returns FName of this tag</summary>
	public static string GetTagName(FGameplayTag GameplayTag) { return default; }
	///<summary>Creates a literal FGameplayTag</summary>
	public static FGameplayTag MakeLiteralGameplayTag(FGameplayTag Value) { return default; }
	///<summary>Get the number of gameplay tags in the specified container</summary>
	public static int GetNumGameplayTagsInContainer(FGameplayTagContainer TagContainer) { return default; }
	///<summary>Check if the tag container has the specified tag</summary>
	public static bool HasTag(FGameplayTagContainer TagContainer,FGameplayTag Tag,bool bExactMatch) { return default; }
	///<summary>Check if the specified tag container has ANY of the tags in the other container</summary>
	public static bool HasAnyTags(FGameplayTagContainer TagContainer,FGameplayTagContainer OtherContainer,bool bExactMatch) { return default; }
	///<summary>Check if the specified tag container has ALL of the tags in the other container</summary>
	public static bool HasAllTags(FGameplayTagContainer TagContainer,FGameplayTagContainer OtherContainer,bool bExactMatch) { return default; }
	///<summary>Check if the specified tag query is empty</summary>
	public static bool IsTagQueryEmpty(FGameplayTagQuery TagQuery) { return default; }
	///<summary>Check if the specified tag container matches the given Tag Query</summary>
	public static bool DoesContainerMatchTagQuery(FGameplayTagContainer TagContainer,FGameplayTagQuery TagQuery) { return default; }
	///<summary>Get an array of all actors of a specific class (or subclass of that class) which match the specified gameplay tag query.</summary>
	public static void GetAllActorsOfClassMatchingTagQuery(UObject WorldContextObject,UClass ActorClass,FGameplayTagQuery GameplayTagQuery,TArray<AActor> OutActors) {}
	///<summary>Adds a single tag to the passed in tag container</summary>
	public static void AddGameplayTag(FGameplayTagContainer TagContainer,FGameplayTag Tag) {}
	///<summary>Remove a single tag from the passed in tag container, returns true if found</summary>
	public static bool RemoveGameplayTag(FGameplayTagContainer TagContainer,FGameplayTag Tag) { return default; }
	///<summary>Appends all tags in the InTagContainer to InOutTagContainer</summary>
	public static void AppendGameplayTagContainers(FGameplayTagContainer InOutTagContainer,FGameplayTagContainer InTagContainer) {}
	///<summary>Returns true if the values are equal (A == B)</summary>
	public static bool EqualEqual_GameplayTagContainer(FGameplayTagContainer A,FGameplayTagContainer B) { return default; }
	///<summary>Returns true if the values are not equal (A != B)</summary>
	public static bool NotEqual_GameplayTagContainer(FGameplayTagContainer A,FGameplayTagContainer B) { return default; }
	///<summary>Creates a literal FGameplayTagContainer</summary>
	public static FGameplayTagContainer MakeLiteralGameplayTagContainer(FGameplayTagContainer Value) { return default; }
	///<summary>Creates a FGameplayTagContainer from the array of passed in tags</summary>
	public static FGameplayTagContainer MakeGameplayTagContainerFromArray(TArray<FGameplayTag> GameplayTags) { return default; }
	///<summary>Creates a FGameplayTagContainer containing a single tag</summary>
	public static FGameplayTagContainer MakeGameplayTagContainerFromTag(FGameplayTag SingleTag) { return default; }
	///<summary>Breaks tag container into explicit array of tags</summary>
	public static void BreakGameplayTagContainer(FGameplayTagContainer GameplayTagContainer,TArray<FGameplayTag> GameplayTags) {}
	///<summary>Creates a literal FGameplayTagQuery</summary>
	public static FGameplayTagQuery MakeGameplayTagQuery(FGameplayTagQuery TagQuery) { return default; }
	///<summary>Check Gameplay tags in the interface has all of the specified tags in the tag container (expands to include parents of asset tags)</summary>
	public static bool HasAllMatchingGameplayTags(object /*TagContainerInterface*/ TagContainerInterface,FGameplayTagContainer OtherContainer) { return default; }
	///<summary>Check if the specified tag container has the specified tag, using the specified tag matching types</summary>
	public static bool DoesTagAssetInterfaceHaveTag(object /*TagContainerInterface*/ TagContainerInterface,FGameplayTag Tag) { return default; }
	///<summary>Checks if a gameplay tag&#39;s name and a string are not equal to one another</summary>
	public static bool NotEqual_TagTag(FGameplayTag A,string B) { return default; }
	///<summary>Checks if a gameplay tag containers&#39;s name and a string are not equal to one another</summary>
	public static bool NotEqual_TagContainerTagContainer(FGameplayTagContainer A,string B) { return default; }
	///<summary>Returns an FString listing all of the gameplay tags in the tag container for debugging purposes.</summary>
	public static string GetDebugStringFromGameplayTagContainer(FGameplayTagContainer TagContainer) { return default; }
	///<summary>Returns an FString representation of a gameplay tag for debugging purposes.</summary>
	public static string GetDebugStringFromGameplayTag(FGameplayTag GameplayTag) { return default; }
}
