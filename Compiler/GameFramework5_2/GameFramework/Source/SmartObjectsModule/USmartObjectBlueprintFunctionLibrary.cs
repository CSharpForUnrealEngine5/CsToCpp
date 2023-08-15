namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("SmartObjectBlueprintFunctionLibrary.h")]
public partial class USmartObjectBlueprintFunctionLibrary : UBlueprintFunctionLibrary {
	public static UClass StaticClass() {return default;}
	///<summary>GetValueAsSOClaimHandle</summary>
	public static FSmartObjectClaimHandle GetValueAsSOClaimHandle(UBlackboardComponent BlackboardComponent,FName KeyName) { return default; }
	///<summary>SetValueAsSOClaimHandle</summary>
	public static void SetValueAsSOClaimHandle(UBlackboardComponent BlackboardComponent,FName KeyName,FSmartObjectClaimHandle Value) {}
	///<summary>IsValidSmartObjectClaimHandle</summary>
	public static bool IsValidSmartObjectClaimHandle(FSmartObjectClaimHandle Handle) { return default; }
	///<summary>Adds to the simulation all smart objects for an actor or removes them according to &#39;bAdd&#39;.</summary>
	public static bool AddOrRemoveSmartObject(AActor SmartObject,bool bEnabled) { return default; }
	///<summary>Adds to the simulation all smart objects for multiple actors or removes them according to &#39;bAdd&#39;.</summary>
	public static bool AddOrRemoveMultipleSmartObjects(TArray<AActor> SmartObjectActors,bool bAdd) { return default; }
	///<summary>Adds to the simulation all smart objects for an actor.</summary>
	public static bool AddSmartObject(AActor SmartObjectActor) { return default; }
	///<summary>Adds to the simulation all smart objects for multiple actors.</summary>
	public static bool AddMultipleSmartObjects(TArray<AActor> SmartObjectActors) { return default; }
	///<summary>Removes from the simulation all smart objects for an actor.</summary>
	public static bool RemoveSmartObject(AActor SmartObjectActor) { return default; }
	///<summary>Removes from the simulation all smart objects for multiple actors.</summary>
	public static bool RemoveMultipleSmartObjects(TArray<AActor> SmartObjectActors) { return default; }
	///<summary>Marks all smart objects for an actor as enabled or not according to &#39;bEnabled&#39;. A smart object marked as Enabled is available for queries.</summary>
	public static bool SetSmartObjectEnabled(AActor SmartObjectActor,bool bEnabled) { return default; }
	///<summary>Marks all smart objects for a list of actors as enabled or not according to &#39;bEnabled&#39;. A smart object marked as Enabled is available for queries.</summary>
	public static bool SetMultipleSmartObjectsEnabled(TArray<AActor> SmartObjectActors,bool bEnabled) { return default; }
	///<summary>SetBlackboardValueAsSOClaimHandle</summary>
	public static void SetBlackboardValueAsSOClaimHandle(UBTNode NodeOwner,FBlackboardKeySelector Key,FSmartObjectClaimHandle Value) {}
	///<summary>GetBlackboardValueAsSOClaimHandle</summary>
	public static FSmartObjectClaimHandle GetBlackboardValueAsSOClaimHandle(UBTNode NodeOwner,FBlackboardKeySelector Key) { return default; }
}
