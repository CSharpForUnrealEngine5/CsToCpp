namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>The Enhanced Input User Settings class is a place where you can put all of your Input Related settings</summary>
[CppInclude("UserSettings/EnhancedInputUserSettings.h")]
public partial class UEnhancedInputUserSettings : USaveGame {
	public static UClass StaticClass() {return default;}
	///<summary>Apply any custom input settings to your user. By default, this will just broadcast the OnSettingsApplied delegate</summary>
	public virtual void ApplySettings() {}
	///<summary>Synchronously save the settings to a hardcoded save game slot. This will work for simple games,</summary>
	public virtual void SaveSettings() {}
	///<summary>Asynchronously save the settings to a hardcoded save game slot. This will work for simple games,</summary>
	public virtual void AsyncSaveSettings() {}
	///<summary>Fired when the user settings have changed, such as their key mappings.</summary>
	public void FEnhancedInputUserSettingsChanged(UEnhancedInputUserSettings Settings) {}
	///<summary>OnSettingsChanged</summary>
	public FEnhancedInputUserSettingsChanged OnSettingsChanged;
	///<summary>Called after the settings have been applied from the ApplySettings call.</summary>
	public void FEnhancedInputUserSettingsApplied() {}
	///<summary>OnSettingsApplied</summary>
	public FEnhancedInputUserSettingsApplied OnSettingsApplied;
	///<summary>Sets the player mapped key on the current key profile.</summary>
	public virtual void MapPlayerKey(FMapPlayerKeyArgs InArgs,FGameplayTagContainer FailureReason) {}
	///<summary>Unmaps a single player mapping that matches the given Mapping name, slot, and hardware device.</summary>
	public virtual void UnMapPlayerKey(FMapPlayerKeyArgs InArgs,FGameplayTagContainer FailureReason) {}
	///<summary>Resets each player mapped key to it&#39;s default value from the Input Mapping Context that it was registered from.</summary>
	public virtual void ResetAllPlayerKeysInRow(FMapPlayerKeyArgs InArgs,FGameplayTagContainer FailureReason) {}
	///<summary>Resets the given key profile to default key mappings</summary>
	public virtual void ResetKeyProfileToDefault(FGameplayTag ProfileId,FGameplayTagContainer FailureReason) {}
	///<summary>Returns a set of all player key mappings for the given mapping name.</summary>
	public virtual TSet<FPlayerKeyMapping> FindMappingsInRow(FName MappingName) { return default; }
	///<summary>Fired when you equip a different key profile</summary>
	public void FMappableKeyProfileChanged(UEnhancedPlayerMappableKeyProfile NewProfile) {}
	///<summary>Changes the currently active key profile to the one with the given name. Returns true if the operation was successful.</summary>
	public virtual bool SetKeyProfile(FGameplayTag InProfileId) { return default; }
	///<summary>Gets the currently selected key profile</summary>
	public virtual FGameplayTag GetCurrentKeyProfileIdentifier() { return default; }
	///<summary>Get the current key profile that the user has set</summary>
	public UEnhancedPlayerMappableKeyProfile GetCurrentKeyProfile() { return default; }
	///<summary>Creates a new profile with this name and type.</summary>
	public virtual UEnhancedPlayerMappableKeyProfile CreateNewKeyProfile(FPlayerMappableKeyProfileCreationArgs InArgs) { return default; }
	///<summary>Returns the key profile with the given name if one exists. Null if one doesn&#39;t exist</summary>
	public virtual UEnhancedPlayerMappableKeyProfile GetKeyProfileWithIdentifier(FGameplayTag ProfileId) { return default; }
	///<summary>Fired when a new input mapping context is registered. Useful if you need to update your UI</summary>
	public void FMappingContextRegisteredWithSettings(UInputMappingContext IMC) {}
	///<summary>Registers this mapping context with the user settings. This will iterate all the key mappings</summary>
	public virtual bool RegisterInputMappingContext(UInputMappingContext IMC) { return default; }
	///<summary>Registers multiple mapping contexts with the settings</summary>
	public bool RegisterInputMappingContexts(TSet<UInputMappingContext> MappingContexts) { return default; }
	///<summary>Removes this mapping context from the registered mapping contexts</summary>
	public virtual bool UnregisterInputMappingContext(UInputMappingContext IMC) { return default; }
	///<summary>Removes multiple mapping contexts from the registered mapping contexts</summary>
	public bool UnregisterInputMappingContexts(TSet<UInputMappingContext> MappingContexts) { return default; }
	///<summary>Returns true if this mapping context is currently registered with the settings</summary>
	public bool IsMappingContextRegistered(UInputMappingContext IMC) { return default; }
	///<summary>The current key profile that is equipped by the user.</summary>
	public FGameplayTag CurrentProfileIdentifier;
	///<summary>All of the known Key Profiles for this user, including the currently active profile.</summary>
	public TMap<FGameplayTag,UEnhancedPlayerMappableKeyProfile> SavedKeyProfiles;
	///<summary>The owning Local Player object of these settings</summary>
	public TWeakObjectPtr<ULocalPlayer> OwningLocalPlayer;
	///<summary>Set of currently registered input mapping contexts that may not be currently</summary>
	public TSet<UInputMappingContext> RegisteredMappingContexts;
}
