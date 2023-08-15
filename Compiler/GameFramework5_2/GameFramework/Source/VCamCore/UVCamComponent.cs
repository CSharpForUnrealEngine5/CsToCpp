namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Provides a modular system for editing a UCineCameraComponent using user widgets.</summary>
[CppInclude("VCamComponent.h")]
public partial class UVCamComponent : USceneComponent {
	public static UClass StaticClass() {return default;}
	///<summary>There are situations in the editor where the component may be replaced by another component as part of the actor being reconstructed</summary>
	public FOnComponentReplaced OnComponentReplaced;
	///<summary>HandleObjectReplaced</summary>
	public void HandleObjectReplaced(TMap<UObject,UObject> ReplacementMap) {}
	///<summary>Attempts to apply key mapping settings from an input profile defined in VCam Input Settings</summary>
	public bool SetInputProfileFromName(FName ProfileName) { return default; }
	///<summary>Tries to add a new Input Profile to the VCam Input Settings and populates it with any currently active player mappable keys</summary>
	public bool AddInputProfileWithCurrentlyActiveMappings(FName ProfileName,bool bUpdateIfProfileAlreadyExists/*=true*/) { return default; }
	///<summary>Saves the current input profile settings to the VCam Input Settings using the provided Profile Name</summary>
	public bool SaveCurrentInputProfileToSettings(FName ProfileName) { return default; }
	///<summary>Searches the currently active input system for all registered key mappings that are marked as Player Mappable.</summary>
	public TArray<FEnhancedActionKeyMapping> GetAllPlayerMappableActionKeyMappings() { return default; }
	///<summary>Searches the currently active input system for the current key mapped to a given input mapping</summary>
	public FKey GetPlayerMappedKey(FName MappingName) { return default; }
	///<summary>Sets whether the VCamComponent will update every frame</summary>
	public void SetEnabled(bool bNewEnabled) {}
	///<summary>@return Whether the VCamComponent will update every frame</summary>
	public bool IsEnabled() { return default; }
	///<summary>GetTargetCamera</summary>
	public UCineCameraComponent GetTargetCamera() { return default; }
	///<summary>Add a modifier to the stack with a given name.</summary>
	public bool AddModifier(FName Name,UClass ModifierClass,UVCamModifier CreatedModifier) { return default; }
	///<summary>Insert a modifier to the stack with a given name and index.</summary>
	public bool InsertModifier(FName Name,int Index,UClass ModifierClass,UVCamModifier CreatedModifier) { return default; }
	///<summary>Moves an existing modifier in the stack from its current index to a new index</summary>
	public bool SetModifierIndex(int OriginalIndex,int NewIndex) { return default; }
	///<summary>Remove all Modifiers from the Stack.</summary>
	public void RemoveAllModifiers() {}
	///<summary>@return Whether the modifier was removed successfully</summary>
	public bool RemoveModifier(UVCamModifier Modifier) { return default; }
	///<summary>@return Whether the modifier was removed successfully</summary>
	public bool RemoveModifierByIndex(int ModifierIndex) { return default; }
	///<summary>@return Whether the modifier was removed successfully.</summary>
	public bool RemoveModifierByName(FName Name) { return default; }
	///<summary>GetNumberOfModifiers</summary>
	public int GetNumberOfModifiers() { return default; }
	///<summary>Returns all the Modifiers in the Component&#39;s Stack</summary>
	public void GetAllModifiers(TArray<UVCamModifier> Modifiers) {}
	///<summary>Returns all the modifier names used to identifying connection points.</summary>
	public TArray<FName> GetAllModifierNames() { return default; }
	///<summary>Returns the Modifier in the Stack with the given index if it exist.</summary>
	public UVCamModifier GetModifierByIndex(int Index) { return default; }
	///<summary>Tries to find a Modifier in the Stack with the given name. The returned Modifier must be checked before it is used.</summary>
	public UVCamModifier GetModifierByName(FName Name) { return default; }
	///<summary>Given a specific Modifier class, returns a list of matching Modifiers</summary>
	public void GetModifiersByClass(UClass ModifierClass,TArray<UVCamModifier> FoundModifiers) {}
	///<summary>Given a specific Interface class, returns a list of matching Modifiers</summary>
	public void GetModifiersByInterface(UClass InterfaceClass,TArray<UVCamModifier> FoundModifiers) {}
	///<summary>Sets the Modifier Context to a new instance of the provided class</summary>
	public void SetModifierContextClass(UClass ContextClass,UVCamModifierContext CreatedContext) {}
	///<summary>Get the current Modifier Context</summary>
	public UVCamModifierContext GetModifierContext() { return default; }
	///<summary>***************** Output Provider access *******************</summary>
	public bool AddOutputProvider(UClass ProviderClass,UVCamOutputProviderBase CreatedProvider) { return default; }
	///<summary>InsertOutputProvider</summary>
	public bool InsertOutputProvider(int Index,UClass ProviderClass,UVCamOutputProviderBase CreatedProvider) { return default; }
	///<summary>Moves an existing Output Provider in the stack from its current index to a new index</summary>
	public bool SetOutputProviderIndex(int OriginalIndex,int NewIndex) { return default; }
	///<summary>RemoveAllOutputProviders</summary>
	public void RemoveAllOutputProviders() {}
	///<summary>RemoveOutputProvider</summary>
	public bool RemoveOutputProvider(UVCamOutputProviderBase Provider) { return default; }
	///<summary>RemoveOutputProviderByIndex</summary>
	public bool RemoveOutputProviderByIndex(int ProviderIndex) { return default; }
	///<summary>GetNumberOfOutputProviders</summary>
	public int GetNumberOfOutputProviders() { return default; }
	///<summary>GetAllOutputProviders</summary>
	public void GetAllOutputProviders(TArray<UVCamOutputProviderBase> Providers) {}
	///<summary>GetOutputProviderByIndex</summary>
	public UVCamOutputProviderBase GetOutputProviderByIndex(int ProviderIndex) { return default; }
	///<summary>GetOutputProvidersByClass</summary>
	public void GetOutputProvidersByClass(UClass ProviderClass,TArray<UVCamOutputProviderBase> FoundProviders) {}
	///<summary>GetLiveLinkDataForCurrentFrame</summary>
	public void GetLiveLinkDataForCurrentFrame(FLiveLinkCameraBlueprintData LiveLinkData) {}
	///<summary>Registers the given object with the VCamComponent&#39;s Input Component</summary>
	public void RegisterObjectForInput(UObject Object) {}
	///<summary>Unregisters the given object with the VCamComponent&#39;s Input Component</summary>
	public void UnregisterObjectForInput(UObject Object) {}
	///<summary>Returns a list of all player mappable keys that have been registered</summary>
	public TArray<FEnhancedActionKeyMapping> GetPlayerMappableKeys() { return default; }
	///<summary>Injects an input action.</summary>
	public virtual void InjectInputForAction(UInputAction Action,FInputActionValue RawValue,TArray<UInputModifier> Modifiers,TArray<UInputTrigger> Triggers) {}
	///<summary>Injects an input vector for action.</summary>
	public virtual void InjectInputVectorForAction(UInputAction Action,FVector Value,TArray<UInputModifier> Modifiers,TArray<UInputTrigger> Triggers) {}
	///<summary>***************** Blueprint Getters &amp; Setters *******************</summary>
	public FGameplayTag GetRole() { return default; }
	///<summary>SetRole</summary>
	public void SetRole(FGameplayTag Value) {}
	///<summary>GetLiveLinkSubobject</summary>
	public FLiveLinkSubjectName GetLiveLinkSubobject() { return default; }
	///<summary>SetLiveLinkSubobject</summary>
	public void SetLiveLinkSubobject(FLiveLinkSubjectName Value) {}
	///<summary>GetDisableComponentWhenSpawnedBySequencer</summary>
	public bool GetDisableComponentWhenSpawnedBySequencer() { return default; }
	///<summary>SetDisableComponentWhenSpawnedBySequencer</summary>
	public void SetDisableComponentWhenSpawnedBySequencer(bool bValue) {}
	///<summary>GetDisableOutputOnMultiUserReceiver</summary>
	public bool GetDisableOutputOnMultiUserReceiver() { return default; }
	///<summary>SetDisableOutputOnMultiUserReceiver</summary>
	public void SetDisableOutputOnMultiUserReceiver(bool bValue) {}
	///<summary>GetInputProfile</summary>
	public FVCamInputProfile GetInputProfile() { return default; }
	///<summary>SetInputProfile</summary>
	public void SetInputProfile(FVCamInputProfile NewInputProfile) {}
	///<summary>Gets the current input device settings being used (if this component is enabled) or that will be used (if not enabled).</summary>
	public FVCamInputDeviceConfig GetInputDeviceSettings() { return default; }
	///<summary>Propagates devices settings all the way to the player input. Causes input to be filtered / consumed differently.</summary>
	public void SetInputDeviceSettings(FVCamInputDeviceConfig NewInputProfile) {}
	///<summary>Gets all subsystems implementing this interface</summary>
	public TArray<UVCamSubsystem> GetSubsystemArray(UClass Class) { return default; }
	///<summary>Gets the subsystem responsible for input handling.</summary>
	public UInputVCamSubsystem GetInputVCamSubsystem() { return default; }
	///<summary>Whether the VCamComponent will update every frame</summary>
	public bool bEnabled;
	///<summary>The role of this virtual camera.  If this value is set and the corresponding tag set on the editor matches this value, then this</summary>
	public FGameplayTag Role;
	///<summary>LiveLink subject name for the incoming camera transform</summary>
	public FLiveLinkSubjectName LiveLinkSubject;
	///<summary>If true, render the viewport from the point of view of the parented CineCamera</summary>
	public bool bLockViewportToCamera_DEPRECATED;
	///<summary>Sync with output providers keeping track of which viewports are locked.</summary>
	public FVCamViewportLocker ViewportLocker;
	///<summary>If true, the component will force bEnabled to false when it is part of a spawnable in Sequencer</summary>
	public bool bDisableComponentWhenSpawnedBySequencer;
	///<summary>Do we disable the output if the virtual camera is in a Multi-user session and the camera is a &quot;receiver&quot; from multi-user</summary>
	public bool bDisableOutputOnMultiUserReceiver;
	///<summary>Indicates the frequency which camera updates are sent when in Multi-user mode. This has a minimum value of</summary>
	public float UpdateFrequencyMs;
	///<summary>Which viewport to use for this VCam.</summary>
	public EVCamTargetViewportID TargetViewport_DEPRECATED;
	///<summary>InputProfile</summary>
	public FVCamInputProfile InputProfile;
	///<summary>InputDeviceSettings</summary>
	public FVCamInputDeviceConfig InputDeviceSettings;
	///<summary>List of Output Providers (executed in order)</summary>
	public TArray<UVCamOutputProviderBase> OutputProviders;
	///<summary>Modifier Context object that can be accessed by the Modifier Stack</summary>
	public UVCamModifierContext ModifierContext;
	///<summary>List of Modifiers (executed in order)</summary>
	public TArray<FModifierStackEntry> ModifierStack;
	///<summary>From Ben H: Mark this as Transient/DuplicateTransient so that it is saved on the BP CDO and nowhere else and</summary>
	public UInputComponent InputComponent;
	///<summary>Store the Input Mapping Contexts that have been added via this component</summary>
	public TArray<UInputMappingContext> AppliedInputContexts;
}
