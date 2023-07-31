#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Struct defining where gameplay tags are loaded/saved from. Mostly for the editor</summary>
[CppInclude("GameplayTagsManager.h")]
public partial struct FGameplayTagSource {
	public string SourceName;
	public EGameplayTagSourceType SourceType;
	public UGameplayTagsList SourceTagList;
	public URestrictedGameplayTagsList SourceRestrictedTagList;
}
