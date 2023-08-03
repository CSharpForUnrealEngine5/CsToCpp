#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Holds data about the tag dictionary, is in a singleton UObject</summary>
[CppInclude("GameplayTagsManager.h")]
public partial class UGameplayTagsManager : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Map of gameplay tag source names to source objects</summary>
	public TMap<string,FGameplayTagSource> TagSources;
	///<summary>Holds all of the valid gameplay-related tags that can be applied to assets</summary>
	public TArray<UDataTable> GameplayTagTables;
}
