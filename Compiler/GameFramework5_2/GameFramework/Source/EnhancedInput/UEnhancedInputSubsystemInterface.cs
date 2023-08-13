namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("EnhancedInputSubsystemInterface.h")]
public partial class UEnhancedInputSubsystemInterface : UInterface {
	public static UClass StaticClass() {return default;}
	///<summary>Input simulation via injection. Runs modifiers and triggers delegates as if the input had come through the underlying input system as FKeys.</summary>
	public virtual void InjectInputForAction(UInputAction Action,FInputActionValue RawValue,TArray<UInputModifier> Modifiers,TArray<UInputTrigger> Triggers) {}
	///<summary>Input simulation via injection. Runs modifiers and triggers delegates as if the input had come through the underlying input system as FKeys.</summary>
	public virtual void InjectInputVectorForAction(UInputAction Action,FVector Value,TArray<UInputModifier> Modifiers,TArray<UInputTrigger> Triggers) {}
	///<summary>Remove all applied mapping contexts.</summary>
	public virtual void ClearAllMappings() {}
	///<summary>Add a control mapping context.</summary>
	public virtual void AddMappingContext(UInputMappingContext MappingContext,int Priority,FModifyContextOptions Options/*=new FModifyContextOptions()*/) {}
	///<summary>Remove a specific control context.</summary>
	public virtual void RemoveMappingContext(UInputMappingContext MappingContext,FModifyContextOptions Options/*=new FModifyContextOptions()*/) {}
	///<summary>Flag player for reapplication of all mapping contexts at the end of this frame.</summary>
	public virtual void RequestRebuildControlMappings(FModifyContextOptions Options/*=new FModifyContextOptions()*/,EInputMappingRebuildType RebuildType/*=EInputMappingRebuildType.Rebuild*/) {}
	///<summary>= DefaultMappingIssues::StandardFatal</summary>
	public virtual EMappingQueryResult QueryMapKeyInActiveContextSet(UInputMappingContext InputContext,UInputAction Action,FKey Key,TArray<FMappingQueryIssue> OutIssues,EMappingQueryIssue BlockingIssues) { return default; }
	///<summary>= DefaultMappingIssues::StandardFatal</summary>
	public virtual EMappingQueryResult QueryMapKeyInContextSet(TArray<UInputMappingContext> PrioritizedActiveContexts,UInputMappingContext InputContext,UInputAction Action,FKey Key,TArray<FMappingQueryIssue> OutIssues,EMappingQueryIssue BlockingIssues) { return default; }
	///<summary>Check if a mapping context is applied to this subsystem&#39;s owner.</summary>
	public virtual bool HasMappingContext(UInputMappingContext MappingContext,int OutFoundPriority) { return default; }
	///<summary>Returns the keys mapped to the given action in the active input mapping contexts.</summary>
	public virtual TArray<FKey> QueryKeysMappedToAction(UInputAction Action) { return default; }
	///<summary>Get an array of the currently applied key mappings that are marked as Player Mappable.</summary>
	public virtual TArray<FEnhancedActionKeyMapping> GetAllPlayerMappableActionKeyMappings() { return default; }
	///<summary>Emplace or replace any currently applied key in KeySlot for mapping of MappingName.</summary>
	public virtual int K2_AddPlayerMappedKeyInSlot(string MappingName,FKey NewKey,FPlayerMappableKeySlot KeySlot/*=new FPlayerMappableKeySlot()*/,FModifyContextOptions Options/*=new FModifyContextOptions()*/) { return default; }
	///<summary>Removes player mapped key in the KeySlot for mapping of MappingName.</summary>
	public virtual int K2_RemovePlayerMappedKeyInSlot(string MappingName,FPlayerMappableKeySlot KeySlot/*=new FPlayerMappableKeySlot()*/,FModifyContextOptions Options/*=new FModifyContextOptions()*/) { return default; }
	///<summary>Removes all player mapped keys for mapping of MappingName.</summary>
	public virtual int RemoveAllPlayerMappedKeysForMapping(string MappingName,FModifyContextOptions Options/*=new FModifyContextOptions()*/) { return default; }
	///<summary>Get the player mapped key in first slot to the given mapping name. If there is not a player mapped key, then this will return</summary>
	public virtual FKey K2_GetPlayerMappedKeyInSlot(string MappingName,FPlayerMappableKeySlot KeySlot/*=new FPlayerMappableKeySlot()*/) { return default; }
	///<summary>Get all the player mapped keys to the given mapping name. If there is not a player mapped key, then this will return</summary>
	public virtual TArray<FKey> GetAllPlayerMappedKeys(string MappingName) { return default; }
	///<summary>Remove All PlayerMappedKeys</summary>
	public virtual void RemoveAllPlayerMappedKeys(FModifyContextOptions Options/*=new FModifyContextOptions()*/) {}
	///<summary>Adds all the input mapping contexts inside of this mappable config.</summary>
	public virtual void AddPlayerMappableConfig(UPlayerMappableInputConfig Config,FModifyContextOptions Options/*=new FModifyContextOptions()*/) {}
	///<summary>Removes all the input mapping contexts inside of this mappable config.</summary>
	public virtual void RemovePlayerMappableConfig(UPlayerMappableInputConfig Config,FModifyContextOptions Options/*=new FModifyContextOptions()*/) {}
}
