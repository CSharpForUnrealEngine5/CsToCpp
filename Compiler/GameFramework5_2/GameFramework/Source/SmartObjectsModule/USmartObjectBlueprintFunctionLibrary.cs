#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("SmartObjectBlueprintFunctionLibrary.h")]
public partial class USmartObjectBlueprintFunctionLibrary : UBlueprintFunctionLibrary {
// SmartObjectBlueprintFunctionLibrary
	public static FSmartObjectClaimHandle GetValueAsSOClaimHandle(UBlackboardComponent BlackboardComponent,string KeyName) { return default; }
	public static void SetValueAsSOClaimHandle(UBlackboardComponent BlackboardComponent,string KeyName,FSmartObjectClaimHandle Value) {}
	public static bool IsValidSmartObjectClaimHandle(FSmartObjectClaimHandle Handle) { return default; }
	public static bool AddOrRemoveSmartObject(AActor SmartObject,bool bEnabled) { return default; }
	public static bool AddOrRemoveMultipleSmartObjects(TArray<AActor> SmartObjectActors,bool bAdd) { return default; }
	public static bool AddSmartObject(AActor SmartObjectActor) { return default; }
	public static bool AddMultipleSmartObjects(TArray<AActor> SmartObjectActors) { return default; }
	public static bool RemoveSmartObject(AActor SmartObjectActor) { return default; }
	public static bool RemoveMultipleSmartObjects(TArray<AActor> SmartObjectActors) { return default; }
	public static bool SetSmartObjectEnabled(AActor SmartObjectActor,bool bEnabled) { return default; }
	public static bool SetMultipleSmartObjectsEnabled(TArray<AActor> SmartObjectActors,bool bEnabled) { return default; }
	public static void SetBlackboardValueAsSOClaimHandle(UBTNode NodeOwner,FBlackboardKeySelector Key,FSmartObjectClaimHandle Value) {}
	public static FSmartObjectClaimHandle GetBlackboardValueAsSOClaimHandle(UBTNode NodeOwner,FBlackboardKeySelector Key) { return default; }
}
