#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("SmartObjectBlueprintFunctionLibrary.h")]
public partial class USmartObjectBlueprintFunctionLibrary : UBlueprintFunctionLibrary {
// SmartObjectBlueprintFunctionLibrary
	public FSmartObjectClaimHandle GetValueAsSOClaimHandle(UObject BlackboardComponent,string KeyName) { return default; }
	public void SetValueAsSOClaimHandle(UObject BlackboardComponent,string KeyName,FSmartObjectClaimHandle Value) {}
	public bool IsValidSmartObjectClaimHandle(FSmartObjectClaimHandle Handle) { return default; }
	public bool AddOrRemoveSmartObject(UObject SmartObject,bool bEnabled) { return default; }
	public bool AddOrRemoveMultipleSmartObjects(TArray<UObject> SmartObjectActors,bool bAdd) { return default; }
	public bool AddSmartObject(UObject SmartObjectActor) { return default; }
	public bool AddMultipleSmartObjects(TArray<UObject> SmartObjectActors) { return default; }
	public bool RemoveSmartObject(UObject SmartObjectActor) { return default; }
	public bool RemoveMultipleSmartObjects(TArray<UObject> SmartObjectActors) { return default; }
	public bool SetSmartObjectEnabled(UObject SmartObjectActor,bool bEnabled) { return default; }
	public bool SetMultipleSmartObjectsEnabled(TArray<UObject> SmartObjectActors,bool bEnabled) { return default; }
	public void SetBlackboardValueAsSOClaimHandle(UObject NodeOwner,FBlackboardKeySelector Key,FSmartObjectClaimHandle Value) {}
	public FSmartObjectClaimHandle GetBlackboardValueAsSOClaimHandle(UObject NodeOwner,FBlackboardKeySelector Key) { return default; }
}
