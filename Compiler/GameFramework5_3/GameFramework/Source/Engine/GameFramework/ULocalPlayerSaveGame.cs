namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Abstract subclass of USaveGame that provides utility functions that let you associate a Save Game object with a specific local player.</summary>
[CppInclude("GameFramework/SaveGame.h")]
public partial class ULocalPlayerSaveGame : USaveGame {
	public static UClass StaticClass() {return default;}
	///<summary>Synchronously loads a save game object in the specified slot for the local player, stalling the main thread until it completes.</summary>
	public static ULocalPlayerSaveGame LoadOrCreateSaveGameForLocalPlayer(UClass SaveGameClass,APlayerController LocalPlayerController,string SlotName) { return default; }
	///<summary>Asynchronously loads a save game object in the specified slot for the local player, if this returns true the delegate will get called later.</summary>
	public static bool AsyncLoadOrCreateSaveGameForLocalPlayer(UClass SaveGameClass,APlayerController LocalPlayerController,string SlotName,FOnLocalPlayerSaveGameLoaded Delegate) { return default; }
	///<summary>Synchronously save using the slot and user index, stalling the main thread until it completes.</summary>
	public virtual bool SaveGameToSlotForLocalPlayer() { return default; }
	///<summary>Asynchronously save to the slot and user index.</summary>
	public virtual bool AsyncSaveGameToSlotForLocalPlayer() { return default; }
	///<summary>Returns the local player controller this is associated with, this will be valid if it is ready to save</summary>
	public virtual APlayerController GetLocalPlayerController() { return default; }
	///<summary>Returns the platform user to save to, based on Local Player by default</summary>
	public virtual FPlatformUserId GetPlatformUserId() { return default; }
	///<summary>Returns the user index to save to, based on Local Player by default</summary>
	public virtual int GetPlatformUserIndex() { return default; }
	///<summary>Returns the save slot name to use</summary>
	public virtual string GetSaveSlotName() { return default; }
	///<summary>Returns the game-specific version number this was last saved/loaded as</summary>
	public virtual int GetSavedDataVersion() { return default; }
	///<summary>Returns the invalid save data version, which means it has never been saved/loaded</summary>
	public virtual int GetInvalidDataVersion() { return default; }
	///<summary>Returns the latest save data version, this is used when the new data is saved</summary>
	public virtual int GetLatestDataVersion() { return default; }
	///<summary>Returns true if this was loaded from an existing save</summary>
	public virtual bool WasLoaded() { return default; }
	///<summary>Returns true if a save is in progress</summary>
	public virtual bool IsSaveInProgress() { return default; }
	///<summary>Returns true if it has been saved at least once and the last save was successful</summary>
	public virtual bool WasLastSaveSuccessful() { return default; }
	///<summary>Returns true if a save was ever requested, may still be in progress</summary>
	public virtual bool WasSaveRequested() { return default; }
	///<summary>Resets all saved data to default values, called when the load fails or manually</summary>
	public virtual void ResetToDefault() {}
	///<summary>Blueprint event called to reset all saved data to default, called when the load fails or manually</summary>
	public void OnResetToDefault() {}
	///<summary>Blueprint event called after loading, is not called for newly created saves</summary>
	public void OnPostLoad() {}
	///<summary>Blueprint event called before saving, do any game-specific fixup here</summary>
	public void OnPreSave() {}
	///<summary>Blueprint event called after saving finishes with success/failure result</summary>
	public void OnPostSave(bool bSuccess) {}
	///<summary>The local player this is connected to, can be null if subclasses override Get/Set Local Player or it hasn&#39;t been initialized</summary>
	public ULocalPlayer OwningPlayer;
	///<summary>The slot name this was loaded from and that will be used to save to in the future</summary>
	public string SaveSlotName;
	///<summary>The value of GetLatestDataVersion when this was last saved.</summary>
	public int SavedDataVersion;
	///<summary>The value of SavedDataVersion when a save was last loaded, this will be -1 for newly created saves</summary>
	public int LoadedDataVersion;
	///<summary>Integer that is incremented every time a save has been requested in the current session, can be used to know if one is in progress</summary>
	public int CurrentSaveRequest;
	///<summary>Integer that is set when a save completes successfully, if this equals RequestedSaveCount then the last save was successful</summary>
	public int LastSuccessfulSaveRequest;
	///<summary>Integer that is set when a save fails</summary>
	public int LastErrorSaveRequest;
}
