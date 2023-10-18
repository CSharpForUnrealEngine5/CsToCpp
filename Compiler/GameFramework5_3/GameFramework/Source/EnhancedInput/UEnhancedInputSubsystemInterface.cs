namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("EnhancedInputSubsystemInterface.h")]
public partial class UEnhancedInputSubsystemInterface : UInterface {
	public static UClass StaticClass() {return default;}
	///<summary>GetUserSettings</summary>
	public virtual UEnhancedInputUserSettings GetUserSettings() { return default; }
	///<summary>Callback for when any Enhanced Input user settings have been changed (a new key mapping for example)</summary>
	public virtual void OnUserSettingsChanged(UEnhancedInputUserSettings Settings) {}
	///<summary>A callback for when the user has applied a new mappable key profile.</summary>
	public virtual void OnUserKeyProfileChanged(UEnhancedPlayerMappableKeyProfile InNewProfile) {}
	///<summary>Input simulation via injection. Runs modifiers and triggers delegates as if the input had come through the underlying input system as FKeys.</summary>
	public virtual void InjectInputForAction(UInputAction Action,FInputActionValue RawValue,TArray<UInputModifier> Modifiers,TArray<UInputTrigger> Triggers) {}
	///<summary>Input simulation via injection. Runs modifiers and triggers delegates as if the input had come through the underlying input system as FKeys.</summary>
	public virtual void InjectInputVectorForAction(UInputAction Action,FVector Value,TArray<UInputModifier> Modifiers,TArray<UInputTrigger> Triggers) {}
	///<summary>Input simulation via injection. Runs modifiers and triggers delegates as if the input had come through the underlying input system as FKeys.</summary>
	public virtual void InjectInputForPlayerMapping(FName MappingName,FInputActionValue RawValue,TArray<UInputModifier> Modifiers,TArray<UInputTrigger> Triggers) {}
	///<summary>Input simulation via injection. Runs modifiers and triggers delegates as if the input had come through the underlying input system as FKeys.</summary>
	public virtual void InjectInputVectorForPlayerMapping(FName MappingName,FVector Value,TArray<UInputModifier> Modifiers,TArray<UInputTrigger> Triggers) {}
	///<summary>Starts simulation of input via injection. This injects the given input every tick until it is stopped with StopContinuousInputInjectionForAction.</summary>
	public virtual void StartContinuousInputInjectionForAction(UInputAction Action,FInputActionValue RawValue,TArray<UInputModifier> Modifiers,TArray<UInputTrigger> Triggers) {}
	///<summary>Starts simulation of input via injection. This injects the given input every tick until it is stopped with StopContinuousInputInjectionForAction.</summary>
	public virtual void StartContinuousInputInjectionForPlayerMapping(FName MappingName,FInputActionValue RawValue,TArray<UInputModifier> Modifiers,TArray<UInputTrigger> Triggers) {}
	///<summary>Stops continuous input injection for the given action.</summary>
	public virtual void StopContinuousInputInjectionForAction(UInputAction Action) {}
	///<summary>Stops continuous input injection for the given player mapping name.</summary>
	public virtual void StopContinuousInputInjectionForPlayerMapping(FName MappingName) {}
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
	///<summary>K2_AddPlayerMappedKeyInSlot</summary>
	public virtual int K2_AddPlayerMappedKeyInSlot(FName MappingName,FKey NewKey,FPlayerMappableKeySlot KeySlot/*=new FPlayerMappableKeySlot()*/,FModifyContextOptions Options/*=new FModifyContextOptions()*/) { return default; }
	///<summary>Removes player mapped key in the KeySlot for mapping of MappingName.</summary>
	public virtual int K2_RemovePlayerMappedKeyInSlot(FName MappingName,FPlayerMappableKeySlot KeySlot/*=new FPlayerMappableKeySlot()*/,FModifyContextOptions Options/*=new FModifyContextOptions()*/) { return default; }
	///<summary>RemoveAllPlayerMappedKeysForMapping</summary>
	public virtual int RemoveAllPlayerMappedKeysForMapping(FName MappingName,FModifyContextOptions Options/*=new FModifyContextOptions()*/) { return default; }
	///<summary>K2_GetPlayerMappedKeyInSlot</summary>
	public virtual FKey K2_GetPlayerMappedKeyInSlot(FName MappingName,FPlayerMappableKeySlot KeySlot/*=new FPlayerMappableKeySlot()*/) { return default; }
	///<summary>GetAllPlayerMappedKeys</summary>
	public virtual TArray<FKey> GetAllPlayerMappedKeys(FName MappingName) { return default; }
	///<summary>RemoveAllPlayerMappedKeys</summary>
	public virtual void RemoveAllPlayerMappedKeys(FModifyContextOptions Options/*=new FModifyContextOptions()*/) {}
	///<summary>AddPlayerMappableConfig</summary>
	public virtual void AddPlayerMappableConfig(UPlayerMappableInputConfig Config,FModifyContextOptions Options/*=new FModifyContextOptions()*/) {}
	///<summary>RemovePlayerMappableConfig</summary>
	public virtual void RemovePlayerMappableConfig(UPlayerMappableInputConfig Config,FModifyContextOptions Options/*=new FModifyContextOptions()*/) {}
}
