#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("VCamComponent.h")]
///<summary>Provides a modular system for editing a UCineCameraComponent using user widgets.</summary>
public partial class UVCamComponent : USceneComponent {
// VCamComponent
	public FOnComponentReplaced OnComponentReplaced;
	public void HandleObjectReplaced(TMap<UObject,UObject> ReplacementMap) {}
	public bool SetInputProfileFromName(string ProfileName) { return default; }
	public bool AddInputProfileWithCurrentlyActiveMappings(string ProfileName,bool bUpdateIfProfileAlreadyExists/*=true*/) { return default; }
	public bool SaveCurrentInputProfileToSettings(string ProfileName) { return default; }
	public TArray<FEnhancedActionKeyMapping> GetAllPlayerMappableActionKeyMappings() { return default; }
	public FKey GetPlayerMappedKey(string MappingName) { return default; }
	public void SetEnabled(bool bNewEnabled) {}
	public bool IsEnabled() { return default; }
	public UObject GetTargetCamera() { return default; }
	public bool AddModifier(string Name,UClass ModifierClass,UObject CreatedModifier) { return default; }
	public bool InsertModifier(string Name,int Index,UClass ModifierClass,UObject CreatedModifier) { return default; }
	public bool SetModifierIndex(int OriginalIndex,int NewIndex) { return default; }
	public void RemoveAllModifiers() {}
	public bool RemoveModifier(UObject Modifier) { return default; }
	public bool RemoveModifierByIndex(int ModifierIndex) { return default; }
	public bool RemoveModifierByName(string Name) { return default; }
	public int GetNumberOfModifiers() { return default; }
	public void GetAllModifiers(TArray<UObject> Modifiers) {}
	public TArray<string> GetAllModifierNames() { return default; }
	public UObject GetModifierByIndex(int Index) { return default; }
	public UObject GetModifierByName(string Name) { return default; }
	public void GetModifiersByClass(UClass ModifierClass,TArray<UObject> FoundModifiers) {}
	public void GetModifiersByInterface(UClass InterfaceClass,TArray<UObject> FoundModifiers) {}
	public void SetModifierContextClass(UClass ContextClass,UObject CreatedContext) {}
	public UObject GetModifierContext() { return default; }
	public bool AddOutputProvider(UClass ProviderClass,UObject CreatedProvider) { return default; }
	public bool InsertOutputProvider(int Index,UClass ProviderClass,UObject CreatedProvider) { return default; }
	public bool SetOutputProviderIndex(int OriginalIndex,int NewIndex) { return default; }
	public void RemoveAllOutputProviders() {}
	public bool RemoveOutputProvider(UObject Provider) { return default; }
	public bool RemoveOutputProviderByIndex(int ProviderIndex) { return default; }
	public int GetNumberOfOutputProviders() { return default; }
	public void GetAllOutputProviders(TArray<UObject> Providers) {}
	public UObject GetOutputProviderByIndex(int ProviderIndex) { return default; }
	public void GetOutputProvidersByClass(UClass ProviderClass,TArray<UObject> FoundProviders) {}
	public void GetLiveLinkDataForCurrentFrame(FLiveLinkCameraBlueprintData LiveLinkData) {}
	public void RegisterObjectForInput(UObject Object) {}
	public void UnregisterObjectForInput(UObject Object) {}
	public TArray<FEnhancedActionKeyMapping> GetPlayerMappableKeys() { return default; }
	public void InjectInputForAction(UObject Action,FInputActionValue RawValue,TArray<UObject> Modifiers,TArray<UObject> Triggers) {}
	public void InjectInputVectorForAction(UObject Action,FVector Value,TArray<UObject> Modifiers,TArray<UObject> Triggers) {}
	public FGameplayTag GetRole() { return default; }
	public void SetRole(FGameplayTag Value) {}
	public FLiveLinkSubjectName GetLiveLinkSubobject() { return default; }
	public void SetLiveLinkSubobject(FLiveLinkSubjectName Value) {}
	public bool GetDisableComponentWhenSpawnedBySequencer() { return default; }
	public void SetDisableComponentWhenSpawnedBySequencer(bool bValue) {}
	public bool GetDisableOutputOnMultiUserReceiver() { return default; }
	public void SetDisableOutputOnMultiUserReceiver(bool bValue) {}
	public FVCamInputProfile GetInputProfile() { return default; }
	public void SetInputProfile(FVCamInputProfile NewInputProfile) {}
	public FVCamInputDeviceConfig GetInputDeviceSettings() { return default; }
	public void SetInputDeviceSettings(FVCamInputDeviceConfig NewInputProfile) {}
	public TArray<UObject> GetSubsystemArray(UClass Class) { return default; }
	public UObject GetInputVCamSubsystem() { return default; }
	public bool bEnabled;
	public FGameplayTag Role;
	public FLiveLinkSubjectName LiveLinkSubject;
	public bool bLockViewportToCamera_DEPRECATED;
	public FVCamViewportLocker ViewportLocker;
	public bool bDisableComponentWhenSpawnedBySequencer;
	public bool bDisableOutputOnMultiUserReceiver;
	public float UpdateFrequencyMs;
	public EVCamTargetViewportID TargetViewport_DEPRECATED;
	public FVCamInputProfile InputProfile;
	public FVCamInputDeviceConfig InputDeviceSettings;
	public TArray<UVCamOutputProviderBase> OutputProviders;
	public UVCamModifierContext ModifierContext;
	public TArray<FModifierStackEntry> ModifierStack;
	public UInputComponent InputComponent;
	public TArray<UInputMappingContext> AppliedInputContexts;
}
