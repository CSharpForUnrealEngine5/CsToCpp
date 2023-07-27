#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("EnhancedInputSubsystemInterface.h")]
public partial class UEnhancedInputSubsystemInterface : UInterface {
// EnhancedInputSubsystemInterface
	public  void InjectInputForAction(UInputAction Action,FInputActionValue RawValue,TArray<UInputModifier> Modifiers,TArray<UInputTrigger> Triggers) {}
	public  void InjectInputVectorForAction(UInputAction Action,FVector Value,TArray<UInputModifier> Modifiers,TArray<UInputTrigger> Triggers) {}
	public  void ClearAllMappings() {}
	public  void AddMappingContext(UInputMappingContext MappingContext,int Priority,FModifyContextOptions Options/*=new FModifyContextOptions()*/) {}
	public  void RemoveMappingContext(UInputMappingContext MappingContext,FModifyContextOptions Options/*=new FModifyContextOptions()*/) {}
	public  void RequestRebuildControlMappings(FModifyContextOptions Options/*=new FModifyContextOptions()*/,EInputMappingRebuildType RebuildType/*=EInputMappingRebuildType.Rebuild*/) {}
	public  EMappingQueryResult QueryMapKeyInActiveContextSet(UInputMappingContext InputContext,UInputAction Action,FKey Key,TArray<FMappingQueryIssue> OutIssues,EMappingQueryIssue BlockingIssues) { return default; }
	public  EMappingQueryResult QueryMapKeyInContextSet(TArray<UInputMappingContext> PrioritizedActiveContexts,UInputMappingContext InputContext,UInputAction Action,FKey Key,TArray<FMappingQueryIssue> OutIssues,EMappingQueryIssue BlockingIssues) { return default; }
	public  bool HasMappingContext(UInputMappingContext MappingContext,int OutFoundPriority) { return default; }
	public  TArray<FKey> QueryKeysMappedToAction(UInputAction Action) { return default; }
	public  TArray<FEnhancedActionKeyMapping> GetAllPlayerMappableActionKeyMappings() { return default; }
	public  int K2_AddPlayerMappedKeyInSlot(string MappingName,FKey NewKey,FPlayerMappableKeySlot KeySlot/*=new FPlayerMappableKeySlot()*/,FModifyContextOptions Options/*=new FModifyContextOptions()*/) { return default; }
	public  int K2_RemovePlayerMappedKeyInSlot(string MappingName,FPlayerMappableKeySlot KeySlot/*=new FPlayerMappableKeySlot()*/,FModifyContextOptions Options/*=new FModifyContextOptions()*/) { return default; }
	public  int RemoveAllPlayerMappedKeysForMapping(string MappingName,FModifyContextOptions Options/*=new FModifyContextOptions()*/) { return default; }
	public  FKey K2_GetPlayerMappedKeyInSlot(string MappingName,FPlayerMappableKeySlot KeySlot/*=new FPlayerMappableKeySlot()*/) { return default; }
	public  TArray<FKey> GetAllPlayerMappedKeys(string MappingName) { return default; }
	public  void RemoveAllPlayerMappedKeys(FModifyContextOptions Options/*=new FModifyContextOptions()*/) {}
	public  void AddPlayerMappableConfig(UPlayerMappableInputConfig Config,FModifyContextOptions Options/*=new FModifyContextOptions()*/) {}
	public  void RemovePlayerMappableConfig(UPlayerMappableInputConfig Config,FModifyContextOptions Options/*=new FModifyContextOptions()*/) {}
}
