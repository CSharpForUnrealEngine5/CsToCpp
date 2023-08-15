namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Class for importing GameplayTags directly from a config file.</summary>
[CppInclude("GameplayTagsSettings.h")]
public partial class UGameplayTagsSettings : UGameplayTagsList {
	public static UClass StaticClass() {return default;}
	///<summary>If true, will import tags from ini files in the config/tags folder</summary>
	public bool ImportTagsFromConfig;
	///<summary>If true, will give load warnings when reading in saved tag references that are not in the dictionary</summary>
	public bool WarnOnInvalidTags;
	///<summary>If true, will clear any invalid tags when reading in saved tag references that are not in the dictionary</summary>
	public bool ClearInvalidTags;
	///<summary>If true, will allow unloading of tags in the editor when plugins are removed</summary>
	public bool AllowEditorTagUnloading;
	///<summary>If true, will allow unloading of tags in a non-editor gebuild when plugins are removed, this is potentially unsafe and affects requests to unload during play in editor</summary>
	public bool AllowGameTagUnloading;
	///<summary>If true, will replicate gameplay tags by index instead of name. For this to work, tags must be identical on client and server</summary>
	public bool FastReplication;
	///<summary>These characters cannot be used in gameplay tags, in addition to special ones like newline</summary>
	public string InvalidTagCharacters;
	///<summary>Category remapping. This allows base engine tag category meta data to remap to multiple project-specific categories.</summary>
	public TArray<FGameplayTagCategoryRemap> CategoryRemapping;
	///<summary>List of data tables to load tags from</summary>
	public TArray<FSoftObjectPath> GameplayTagTableList;
	///<summary>List of active tag redirects</summary>
	public TArray<FGameplayTagRedirect> GameplayTagRedirects;
	///<summary>List of most frequently replicated tags</summary>
	public TArray<FName> CommonlyReplicatedTags;
	///<summary>Numbers of bits to use for replicating container size, set this based on how large your containers tend to be</summary>
	public int NumBitsForContainerSize;
	///<summary>The length in bits of the first segment when net serializing tags. We will serialize NetIndexFirstBitSegment + 1 bit to indicate &quot;more&quot;, which is slower to replicate</summary>
	public int NetIndexFirstBitSegment;
	///<summary>A list of .ini files used to store restricted gameplay tags.</summary>
	public TArray<FRestrictedConfigInfo> RestrictedConfigFiles;
	///<summary>Restricted Gameplay Tags.</summary>
	public string RestrictedTagList;
}
