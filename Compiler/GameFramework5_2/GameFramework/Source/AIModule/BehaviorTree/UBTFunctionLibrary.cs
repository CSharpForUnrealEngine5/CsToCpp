#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("BehaviorTree/BTFunctionLibrary.h")]
public partial class UBTFunctionLibrary : UBlueprintFunctionLibrary {
	public static UClass StaticClass() {return default;}
	///<summary>GetOwnersBlackboard</summary>
	public static UBlackboardComponent GetOwnersBlackboard(UBTNode NodeOwner) { return default; }
	///<summary>GetOwnerComponent</summary>
	public static UBehaviorTreeComponent GetOwnerComponent(UBTNode NodeOwner) { return default; }
	///<summary>GetBlackboardValueAsObject</summary>
	public static UObject GetBlackboardValueAsObject(UBTNode NodeOwner,FBlackboardKeySelector Key) { return default; }
	///<summary>GetBlackboardValueAsActor</summary>
	public static AActor GetBlackboardValueAsActor(UBTNode NodeOwner,FBlackboardKeySelector Key) { return default; }
	///<summary>GetBlackboardValueAsClass</summary>
	public static UClass GetBlackboardValueAsClass(UBTNode NodeOwner,FBlackboardKeySelector Key) { return default; }
	///<summary>GetBlackboardValueAsEnum</summary>
	public static byte GetBlackboardValueAsEnum(UBTNode NodeOwner,FBlackboardKeySelector Key) { return default; }
	///<summary>GetBlackboardValueAsInt</summary>
	public static int GetBlackboardValueAsInt(UBTNode NodeOwner,FBlackboardKeySelector Key) { return default; }
	///<summary>GetBlackboardValueAsFloat</summary>
	public static float GetBlackboardValueAsFloat(UBTNode NodeOwner,FBlackboardKeySelector Key) { return default; }
	///<summary>GetBlackboardValueAsBool</summary>
	public static bool GetBlackboardValueAsBool(UBTNode NodeOwner,FBlackboardKeySelector Key) { return default; }
	///<summary>GetBlackboardValueAsString</summary>
	public static string GetBlackboardValueAsString(UBTNode NodeOwner,FBlackboardKeySelector Key) { return default; }
	///<summary>GetBlackboardValueAsName</summary>
	public static string GetBlackboardValueAsName(UBTNode NodeOwner,FBlackboardKeySelector Key) { return default; }
	///<summary>GetBlackboardValueAsVector</summary>
	public static FVector GetBlackboardValueAsVector(UBTNode NodeOwner,FBlackboardKeySelector Key) { return default; }
	///<summary>GetBlackboardValueAsRotator</summary>
	public static FRotator GetBlackboardValueAsRotator(UBTNode NodeOwner,FBlackboardKeySelector Key) { return default; }
	///<summary>SetBlackboardValueAsObject</summary>
	public static void SetBlackboardValueAsObject(UBTNode NodeOwner,FBlackboardKeySelector Key,UObject Value) {}
	///<summary>SetBlackboardValueAsClass</summary>
	public static void SetBlackboardValueAsClass(UBTNode NodeOwner,FBlackboardKeySelector Key,UClass Value) {}
	///<summary>SetBlackboardValueAsEnum</summary>
	public static void SetBlackboardValueAsEnum(UBTNode NodeOwner,FBlackboardKeySelector Key,byte Value) {}
	///<summary>SetBlackboardValueAsInt</summary>
	public static void SetBlackboardValueAsInt(UBTNode NodeOwner,FBlackboardKeySelector Key,int Value) {}
	///<summary>SetBlackboardValueAsFloat</summary>
	public static void SetBlackboardValueAsFloat(UBTNode NodeOwner,FBlackboardKeySelector Key,float Value) {}
	///<summary>SetBlackboardValueAsBool</summary>
	public static void SetBlackboardValueAsBool(UBTNode NodeOwner,FBlackboardKeySelector Key,bool Value) {}
	///<summary>SetBlackboardValueAsString</summary>
	public static void SetBlackboardValueAsString(UBTNode NodeOwner,FBlackboardKeySelector Key,string Value) {}
	///<summary>SetBlackboardValueAsName</summary>
	public static void SetBlackboardValueAsName(UBTNode NodeOwner,FBlackboardKeySelector Key,string Value) {}
	///<summary>SetBlackboardValueAsVector</summary>
	public static void SetBlackboardValueAsVector(UBTNode NodeOwner,FBlackboardKeySelector Key,FVector Value) {}
	///<summary>(DEPRECATED) Use ClearBlackboardValue instead</summary>
	public static void ClearBlackboardValueAsVector(UBTNode NodeOwner,FBlackboardKeySelector Key) {}
	///<summary>SetBlackboardValueAsRotator</summary>
	public static void SetBlackboardValueAsRotator(UBTNode NodeOwner,FBlackboardKeySelector Key,FRotator Value) {}
	///<summary>Resets indicated value to &quot;not set&quot; value, based on values type</summary>
	public static void ClearBlackboardValue(UBTNode NodeOwner,FBlackboardKeySelector Key) {}
	///<summary>Initialize variables marked as &quot;instance memory&quot; and set owning actor for blackboard operations</summary>
	public static void StartUsingExternalEvent(UBTNode NodeOwner,AActor OwningActor) {}
	///<summary>Save variables marked as &quot;instance memory&quot; and clear owning actor</summary>
	public static void StopUsingExternalEvent(UBTNode NodeOwner) {}
}
