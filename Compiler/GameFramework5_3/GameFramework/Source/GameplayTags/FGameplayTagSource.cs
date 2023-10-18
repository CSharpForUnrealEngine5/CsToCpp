namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Struct defining where gameplay tags are loaded/saved from. Mostly for the editor</summary>
[CppInclude("GameplayTagsManager.h")]
public partial struct FGameplayTagSource {
	public FName SourceName;
	public EGameplayTagSourceType SourceType;
	public UGameplayTagsList SourceTagList;
	public URestrictedGameplayTagsList SourceRestrictedTagList;
}
