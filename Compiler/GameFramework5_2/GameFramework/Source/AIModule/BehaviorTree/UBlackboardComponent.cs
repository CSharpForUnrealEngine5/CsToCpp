#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("BehaviorTree/BlackboardComponent.h")]
public partial class UBlackboardComponent : UActorComponent {
// BlackboardComponent
	public  UObject GetValueAsObject(string KeyName) { return default; }
	public  UClass GetValueAsClass(string KeyName) { return default; }
	public  byte GetValueAsEnum(string KeyName) { return default; }
	public  int GetValueAsInt(string KeyName) { return default; }
	public  float GetValueAsFloat(string KeyName) { return default; }
	public  bool GetValueAsBool(string KeyName) { return default; }
	public  string GetValueAsString(string KeyName) { return default; }
	public  string GetValueAsName(string KeyName) { return default; }
	public  FVector GetValueAsVector(string KeyName) { return default; }
	public  FRotator GetValueAsRotator(string KeyName) { return default; }
	public  void SetValueAsObject(string KeyName,UObject ObjectValue) {}
	public  void SetValueAsClass(string KeyName,UClass ClassValue) {}
	public  void SetValueAsEnum(string KeyName,byte EnumValue) {}
	public  void SetValueAsInt(string KeyName,int IntValue) {}
	public  void SetValueAsFloat(string KeyName,float FloatValue) {}
	public  void SetValueAsBool(string KeyName,bool BoolValue) {}
	public  void SetValueAsString(string KeyName,string StringValue) {}
	public  void SetValueAsName(string KeyName,string NameValue) {}
	public  void SetValueAsVector(string KeyName,FVector VectorValue) {}
	public  void SetValueAsRotator(string KeyName,FRotator VectorValue) {}
	public  bool IsVectorValueSet(string KeyName) { return default; }
	public  bool GetLocationFromEntry(string KeyName,FVector ResultLocation) { return default; }
	public  bool GetRotationFromEntry(string KeyName,FRotator ResultRotation) { return default; }
	public  void ClearValue(string KeyName) {}
	public UBrainComponent BrainComp;
	public UBlackboardData DefaultBlackboardAsset;
	public UBlackboardData BlackboardAsset;
	public TArray<UBlackboardKeyType> KeyInstances;
}
