#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("BehaviorTree/BTFunctionLibrary.h")]
public partial class UBTFunctionLibrary : UBlueprintFunctionLibrary {
// BTFunctionLibrary
	public UObject GetOwnersBlackboard(UObject NodeOwner) { return default; }
	public UObject GetOwnerComponent(UObject NodeOwner) { return default; }
	public UObject GetBlackboardValueAsObject(UObject NodeOwner,FBlackboardKeySelector Key) { return default; }
	public UObject GetBlackboardValueAsActor(UObject NodeOwner,FBlackboardKeySelector Key) { return default; }
	public UClass GetBlackboardValueAsClass(UObject NodeOwner,FBlackboardKeySelector Key) { return default; }
	public byte GetBlackboardValueAsEnum(UObject NodeOwner,FBlackboardKeySelector Key) { return default; }
	public int GetBlackboardValueAsInt(UObject NodeOwner,FBlackboardKeySelector Key) { return default; }
	public float GetBlackboardValueAsFloat(UObject NodeOwner,FBlackboardKeySelector Key) { return default; }
	public bool GetBlackboardValueAsBool(UObject NodeOwner,FBlackboardKeySelector Key) { return default; }
	public string GetBlackboardValueAsString(UObject NodeOwner,FBlackboardKeySelector Key) { return default; }
	public string GetBlackboardValueAsName(UObject NodeOwner,FBlackboardKeySelector Key) { return default; }
	public FVector GetBlackboardValueAsVector(UObject NodeOwner,FBlackboardKeySelector Key) { return default; }
	public FRotator GetBlackboardValueAsRotator(UObject NodeOwner,FBlackboardKeySelector Key) { return default; }
	public void SetBlackboardValueAsObject(UObject NodeOwner,FBlackboardKeySelector Key,UObject Value) {}
	public void SetBlackboardValueAsClass(UObject NodeOwner,FBlackboardKeySelector Key,UClass Value) {}
	public void SetBlackboardValueAsEnum(UObject NodeOwner,FBlackboardKeySelector Key,byte Value) {}
	public void SetBlackboardValueAsInt(UObject NodeOwner,FBlackboardKeySelector Key,int Value) {}
	public void SetBlackboardValueAsFloat(UObject NodeOwner,FBlackboardKeySelector Key,float Value) {}
	public void SetBlackboardValueAsBool(UObject NodeOwner,FBlackboardKeySelector Key,bool Value) {}
	public void SetBlackboardValueAsString(UObject NodeOwner,FBlackboardKeySelector Key,string Value) {}
	public void SetBlackboardValueAsName(UObject NodeOwner,FBlackboardKeySelector Key,string Value) {}
	public void SetBlackboardValueAsVector(UObject NodeOwner,FBlackboardKeySelector Key,FVector Value) {}
	public void ClearBlackboardValueAsVector(UObject NodeOwner,FBlackboardKeySelector Key) {}
	public void SetBlackboardValueAsRotator(UObject NodeOwner,FBlackboardKeySelector Key,FRotator Value) {}
	public void ClearBlackboardValue(UObject NodeOwner,FBlackboardKeySelector Key) {}
	public void StartUsingExternalEvent(UObject NodeOwner,UObject OwningActor) {}
	public void StopUsingExternalEvent(UObject NodeOwner) {}
}
