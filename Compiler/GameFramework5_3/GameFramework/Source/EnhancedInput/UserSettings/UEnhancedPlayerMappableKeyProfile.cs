namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Represents one &quot;Profile&quot; that a user can have for their player mappable keys</summary>
[CppInclude("UserSettings/EnhancedInputUserSettings.h")]
public partial class UEnhancedPlayerMappableKeyProfile : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>SetDisplayName</summary>
	public virtual void SetDisplayName(FText NewDisplayName) {}
	///<summary>GetProfileIdentifer</summary>
	public FGameplayTag GetProfileIdentifer() { return default; }
	///<summary>Get the localized display name for this profile</summary>
	public FText GetProfileDisplayName() { return default; }
	///<summary>Get all known key mappings for this profile.</summary>
	public TMap<FName,FKeyMappingRow> GetPlayerMappingRows() { return default; }
	///<summary>Resets every player key mapping to this mapping back to it&#39;s default value</summary>
	public void ResetMappingToDefault(FName InMappingName) {}
	///<summary>A helper function to print out all the current profile settings to the log.</summary>
	public virtual void DumpProfileToLog() {}
	///<summary>Returns a string that can be used to debug the current key mappings.</summary>
	public virtual string ToString() { return default; }
	///<summary>OUT</summary>
	public virtual int GetMappedKeysInRow(FName MappingName,TArray<FKey> OutKeys) { return default; }
	///<summary>OUT</summary>
	public virtual int QueryPlayerMappedKeys(FPlayerMappableKeyQueryOptions Options,TArray<FKey> OutKeys) { return default; }
	///<summary>OUT</summary>
	public virtual int GetMappingNamesForKey(FKey InKey,TArray<FName> OutMappingNames) { return default; }
	///<summary>K2_FindKeyMapping</summary>
	public void K2_FindKeyMapping(FPlayerKeyMapping OutKeyMapping,FMapPlayerKeyArgs InArgs) {}
	///<summary>Resets all the key mappings in this profile to their default value from their Input Mapping Context.</summary>
	public virtual void ResetToDefault() {}
	///<summary>Returns true if the given player key mapping passes the query filter provided.</summary>
	public virtual bool DoesMappingPassQueryOptions(FPlayerKeyMapping PlayerMapping,FPlayerMappableKeyQueryOptions Options) { return default; }
	///<summary>The ID of this profile. This can be used by each Key Mapping to filter down which profile is required for it be equipped.</summary>
	public FGameplayTag ProfileIdentifier;
	///<summary>The platform user id of the owning Local Player of this profile.</summary>
	public FPlatformUserId OwningUserId;
	///<summary>The localized display name of this profile</summary>
	public FText DisplayName;
	///<summary>A map of &quot;Mapping Row Name&quot; to all key mappings associated with it.</summary>
	public TMap<FName,FKeyMappingRow> PlayerMappedKeys;
}
