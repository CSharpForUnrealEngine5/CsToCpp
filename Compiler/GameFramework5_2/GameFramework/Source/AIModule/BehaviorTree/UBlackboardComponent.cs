namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("BehaviorTree/BlackboardComponent.h")]
public partial class UBlackboardComponent : UActorComponent {
	public static UClass StaticClass() {return default;}
	///<summary>GetValueAsObject</summary>
	public UObject GetValueAsObject(string KeyName) { return default; }
	///<summary>GetValueAsClass</summary>
	public UClass GetValueAsClass(string KeyName) { return default; }
	///<summary>GetValueAsEnum</summary>
	public byte GetValueAsEnum(string KeyName) { return default; }
	///<summary>GetValueAsInt</summary>
	public int GetValueAsInt(string KeyName) { return default; }
	///<summary>GetValueAsFloat</summary>
	public float GetValueAsFloat(string KeyName) { return default; }
	///<summary>GetValueAsBool</summary>
	public bool GetValueAsBool(string KeyName) { return default; }
	///<summary>GetValueAsString</summary>
	public string GetValueAsString(string KeyName) { return default; }
	///<summary>GetValueAsName</summary>
	public string GetValueAsName(string KeyName) { return default; }
	///<summary>GetValueAsVector</summary>
	public FVector GetValueAsVector(string KeyName) { return default; }
	///<summary>GetValueAsRotator</summary>
	public FRotator GetValueAsRotator(string KeyName) { return default; }
	///<summary>SetValueAsObject</summary>
	public void SetValueAsObject(string KeyName,UObject ObjectValue) {}
	///<summary>SetValueAsClass</summary>
	public void SetValueAsClass(string KeyName,UClass ClassValue) {}
	///<summary>SetValueAsEnum</summary>
	public void SetValueAsEnum(string KeyName,byte EnumValue) {}
	///<summary>SetValueAsInt</summary>
	public void SetValueAsInt(string KeyName,int IntValue) {}
	///<summary>SetValueAsFloat</summary>
	public void SetValueAsFloat(string KeyName,float FloatValue) {}
	///<summary>SetValueAsBool</summary>
	public void SetValueAsBool(string KeyName,bool BoolValue) {}
	///<summary>SetValueAsString</summary>
	public void SetValueAsString(string KeyName,string StringValue) {}
	///<summary>SetValueAsName</summary>
	public void SetValueAsName(string KeyName,string NameValue) {}
	///<summary>SetValueAsVector</summary>
	public void SetValueAsVector(string KeyName,FVector VectorValue) {}
	///<summary>SetValueAsRotator</summary>
	public void SetValueAsRotator(string KeyName,FRotator VectorValue) {}
	///<summary>If the vector value has been set (and not cleared), this function returns true (indicating that the value should be valid).  If it&#39;s not set, the vector value is invalid and this function will return false.  (Also returns false if the key specified does not hold a vector.)</summary>
	public bool IsVectorValueSet(string KeyName) { return default; }
	///<summary>return false if call failed (most probably no such entry in BB)</summary>
	public bool GetLocationFromEntry(string KeyName,FVector ResultLocation) { return default; }
	///<summary>return false if call failed (most probably no such entry in BB)</summary>
	public bool GetRotationFromEntry(string KeyName,FRotator ResultRotation) { return default; }
	///<summary>ClearValue</summary>
	public void ClearValue(string KeyName) {}
	///<summary>cached behavior tree component</summary>
	public UBrainComponent BrainComp;
	///<summary>data asset defining entries. Will be used as part of InitializeComponent</summary>
	public UBlackboardData DefaultBlackboardAsset;
	///<summary>BlackboardAsset</summary>
	public UBlackboardData BlackboardAsset;
	///<summary>instanced keys with custom data allocations</summary>
	public TArray<UBlackboardKeyType> KeyInstances;
}
