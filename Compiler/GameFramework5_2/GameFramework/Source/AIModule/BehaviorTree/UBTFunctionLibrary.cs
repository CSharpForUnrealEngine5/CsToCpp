#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("BehaviorTree/BTFunctionLibrary.h")]
public partial class UBTFunctionLibrary : UBlueprintFunctionLibrary {
// BTFunctionLibrary
	public static UBlackboardComponent GetOwnersBlackboard(UBTNode NodeOwner) { return default; }
	public static UBehaviorTreeComponent GetOwnerComponent(UBTNode NodeOwner) { return default; }
	public static UObject GetBlackboardValueAsObject(UBTNode NodeOwner,FBlackboardKeySelector Key) { return default; }
	public static AActor GetBlackboardValueAsActor(UBTNode NodeOwner,FBlackboardKeySelector Key) { return default; }
	public static UClass GetBlackboardValueAsClass(UBTNode NodeOwner,FBlackboardKeySelector Key) { return default; }
	public static byte GetBlackboardValueAsEnum(UBTNode NodeOwner,FBlackboardKeySelector Key) { return default; }
	public static int GetBlackboardValueAsInt(UBTNode NodeOwner,FBlackboardKeySelector Key) { return default; }
	public static float GetBlackboardValueAsFloat(UBTNode NodeOwner,FBlackboardKeySelector Key) { return default; }
	public static bool GetBlackboardValueAsBool(UBTNode NodeOwner,FBlackboardKeySelector Key) { return default; }
	public static string GetBlackboardValueAsString(UBTNode NodeOwner,FBlackboardKeySelector Key) { return default; }
	public static string GetBlackboardValueAsName(UBTNode NodeOwner,FBlackboardKeySelector Key) { return default; }
	public static FVector GetBlackboardValueAsVector(UBTNode NodeOwner,FBlackboardKeySelector Key) { return default; }
	public static FRotator GetBlackboardValueAsRotator(UBTNode NodeOwner,FBlackboardKeySelector Key) { return default; }
	public static void SetBlackboardValueAsObject(UBTNode NodeOwner,FBlackboardKeySelector Key,UObject Value) {}
	public static void SetBlackboardValueAsClass(UBTNode NodeOwner,FBlackboardKeySelector Key,UClass Value) {}
	public static void SetBlackboardValueAsEnum(UBTNode NodeOwner,FBlackboardKeySelector Key,byte Value) {}
	public static void SetBlackboardValueAsInt(UBTNode NodeOwner,FBlackboardKeySelector Key,int Value) {}
	public static void SetBlackboardValueAsFloat(UBTNode NodeOwner,FBlackboardKeySelector Key,float Value) {}
	public static void SetBlackboardValueAsBool(UBTNode NodeOwner,FBlackboardKeySelector Key,bool Value) {}
	public static void SetBlackboardValueAsString(UBTNode NodeOwner,FBlackboardKeySelector Key,string Value) {}
	public static void SetBlackboardValueAsName(UBTNode NodeOwner,FBlackboardKeySelector Key,string Value) {}
	public static void SetBlackboardValueAsVector(UBTNode NodeOwner,FBlackboardKeySelector Key,FVector Value) {}
	public static void ClearBlackboardValueAsVector(UBTNode NodeOwner,FBlackboardKeySelector Key) {}
	public static void SetBlackboardValueAsRotator(UBTNode NodeOwner,FBlackboardKeySelector Key,FRotator Value) {}
	public static void ClearBlackboardValue(UBTNode NodeOwner,FBlackboardKeySelector Key) {}
	public static void StartUsingExternalEvent(UBTNode NodeOwner,AActor OwningActor) {}
	public static void StopUsingExternalEvent(UBTNode NodeOwner) {}
}
