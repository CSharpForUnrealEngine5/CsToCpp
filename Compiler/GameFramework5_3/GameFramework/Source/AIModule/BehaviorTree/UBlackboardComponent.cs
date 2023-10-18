namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("BehaviorTree/BlackboardComponent.h")]
public partial class UBlackboardComponent : UActorComponent {
	public static UClass StaticClass() {return default;}
	///<summary>GetValueAsObject</summary>
	public UObject GetValueAsObject(FName KeyName) { return default; }
	///<summary>GetValueAsClass</summary>
	public UClass GetValueAsClass(FName KeyName) { return default; }
	///<summary>GetValueAsEnum</summary>
	public byte GetValueAsEnum(FName KeyName) { return default; }
	///<summary>GetValueAsInt</summary>
	public int GetValueAsInt(FName KeyName) { return default; }
	///<summary>GetValueAsFloat</summary>
	public float GetValueAsFloat(FName KeyName) { return default; }
	///<summary>GetValueAsBool</summary>
	public bool GetValueAsBool(FName KeyName) { return default; }
	///<summary>GetValueAsString</summary>
	public string GetValueAsString(FName KeyName) { return default; }
	///<summary>GetValueAsName</summary>
	public FName GetValueAsName(FName KeyName) { return default; }
	///<summary>GetValueAsVector</summary>
	public FVector GetValueAsVector(FName KeyName) { return default; }
	///<summary>GetValueAsRotator</summary>
	public FRotator GetValueAsRotator(FName KeyName) { return default; }
	///<summary>SetValueAsObject</summary>
	public void SetValueAsObject(FName KeyName,UObject ObjectValue) {}
	///<summary>SetValueAsClass</summary>
	public void SetValueAsClass(FName KeyName,UClass ClassValue) {}
	///<summary>SetValueAsEnum</summary>
	public void SetValueAsEnum(FName KeyName,byte EnumValue) {}
	///<summary>SetValueAsInt</summary>
	public void SetValueAsInt(FName KeyName,int IntValue) {}
	///<summary>SetValueAsFloat</summary>
	public void SetValueAsFloat(FName KeyName,float FloatValue) {}
	///<summary>SetValueAsBool</summary>
	public void SetValueAsBool(FName KeyName,bool BoolValue) {}
	///<summary>SetValueAsString</summary>
	public void SetValueAsString(FName KeyName,string StringValue) {}
	///<summary>SetValueAsName</summary>
	public void SetValueAsName(FName KeyName,FName NameValue) {}
	///<summary>SetValueAsVector</summary>
	public void SetValueAsVector(FName KeyName,FVector VectorValue) {}
	///<summary>SetValueAsRotator</summary>
	public void SetValueAsRotator(FName KeyName,FRotator VectorValue) {}
	///<summary>If the vector value has been set (and not cleared), this function returns true (indicating that the value should be valid).  If it&#39;s not set, the vector value is invalid and this function will return false.  (Also returns false if the key specified does not hold a vector.)</summary>
	public bool IsVectorValueSet(FName KeyName) { return default; }
	///<summary>return false if call failed (most probably no such entry in BB)</summary>
	public bool GetLocationFromEntry(FName KeyName,FVector ResultLocation) { return default; }
	///<summary>return false if call failed (most probably no such entry in BB)</summary>
	public bool GetRotationFromEntry(FName KeyName,FRotator ResultRotation) { return default; }
	///<summary>ClearValue</summary>
	public void ClearValue(FName KeyName) {}
	///<summary>cached behavior tree component</summary>
	public UBrainComponent BrainComp;
	///<summary>data asset defining entries. Will be used as part of InitializeComponent</summary>
	public UBlackboardData DefaultBlackboardAsset;
	///<summary>BlackboardAsset</summary>
	public UBlackboardData BlackboardAsset;
	///<summary>instanced keys with custom data allocations</summary>
	public TArray<UBlackboardKeyType> KeyInstances;
}
