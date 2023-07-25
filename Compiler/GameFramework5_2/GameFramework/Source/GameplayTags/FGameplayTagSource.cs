#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GameplayTagsManager.h")]
///<summary>Struct defining where gameplay tags are loaded/saved from. Mostly for the editor</summary>
public partial struct FGameplayTagSource {
// GameplayTagSource
	public string SourceName;
	public EGameplayTagSourceType SourceType;
	public UGameplayTagsList SourceTagList;
	public URestrictedGameplayTagsList SourceRestrictedTagList;
}
