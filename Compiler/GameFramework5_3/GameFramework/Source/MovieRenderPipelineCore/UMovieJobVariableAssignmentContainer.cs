namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Holds a group of properties which override variable values on the job&#39;s associated graph (if any). Overrides are not</summary>
[CppInclude("MovieJobVariableAssignmentContainer.h")]
public partial class UMovieJobVariableAssignmentContainer : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Sets the graph config associated with the variable assignments. Calls UpdateGraphVariableOverrides() to ensure</summary>
	public void SetGraphConfig(TSoftObjectPtr<UMovieGraphConfig> InGraphConfig) {}
	///<summary>Gets the bool value of the specified property. Returns true on success, else false.</summary>
	public bool GetValueBool(FName PropertyName,bool bOutValue) { return default; }
	///<summary>Gets the byte value of the specified property. Returns true on success, else false.</summary>
	public bool GetValueByte(FName PropertyName,byte OutValue) { return default; }
	///<summary>Gets the int32 value of the specified property. Returns true on success, else false.</summary>
	public bool GetValueInt32(FName PropertyName,int OutValue) { return default; }
	///<summary>Gets the int64 value of the specified property. Returns true on success, else false.</summary>
	public bool GetValueInt64(FName PropertyName,long OutValue) { return default; }
	///<summary>Gets the float value of the specified property. Returns true on success, else false.</summary>
	public bool GetValueFloat(FName PropertyName,float OutValue) { return default; }
	///<summary>Gets the double value of the specified property. Returns true on success, else false.</summary>
	public bool GetValueDouble(FName PropertyName,double OutValue) { return default; }
	///<summary>Gets the FName value of the specified property. Returns true on success, else false.</summary>
	public bool GetValueName(FName PropertyName,FName OutValue) { return default; }
	///<summary>Gets the FString value of the specified property. Returns true on success, else false.</summary>
	public bool GetValueString(FName PropertyName,string OutValue) { return default; }
	///<summary>Gets the FText value of the specified property. Returns true on success, else false.</summary>
	public bool GetValueText(FName PropertyName,FText OutValue) { return default; }
	///<summary>Gets the enum value (for a specific enum) of the specified property. Returns true on success, else false.</summary>
	public bool GetValueEnum(FName PropertyName,byte OutValue,UEnum RequestedEnum/*=nullptr*/) { return default; }
	///<summary>Gets the object value (for a specific class) of the specified property. Returns true on success, else false.</summary>
	public bool GetValueObject(FName PropertyName,UObject OutValue,UClass RequestedClass/*=nullptr*/) { return default; }
	///<summary>Gets the UClass value of the specified property. Returns true on success, else false.</summary>
	public bool GetValueClass(FName PropertyName,UClass OutValue) { return default; }
	///<summary>Gets the serialized string value of the specified property.</summary>
	public string GetValueSerializedString(FName PropertyName) { return default; }
	///<summary>Sets the bool value of the specified property. Returns true on success, else false.</summary>
	public bool SetValueBool(FName PropertyName,bool bInValue) { return default; }
	///<summary>Sets the byte value of the specified property. Returns true on success, else false.</summary>
	public bool SetValueByte(FName PropertyName,byte InValue) { return default; }
	///<summary>Sets the int32 value of the specified property. Returns true on success, else false.</summary>
	public bool SetValueInt32(FName PropertyName,int InValue) { return default; }
	///<summary>Sets the int64 value of the specified property. Returns true on success, else false.</summary>
	public bool SetValueInt64(FName PropertyName,long InValue) { return default; }
	///<summary>Sets the float value of the specified property. Returns true on success, else false.</summary>
	public bool SetValueFloat(FName PropertyName,float InValue) { return default; }
	///<summary>Sets the double value of the specified property. Returns true on success, else false.</summary>
	public bool SetValueDouble(FName PropertyName,double InValue) { return default; }
	///<summary>Sets the FName value of the specified property. Returns true on success, else false.</summary>
	public bool SetValueName(FName PropertyName,FName InValue) { return default; }
	///<summary>Sets the FString value of the specified property. Returns true on success, else false.</summary>
	public bool SetValueString(FName PropertyName,string InValue) { return default; }
	///<summary>Sets the FText value of the specified property. Returns true on success, else false.</summary>
	public bool SetValueText(FName PropertyName,FText InValue) { return default; }
	///<summary>Sets the enum value of the specified property. Returns true on success, else false.</summary>
	public bool SetValueEnum(FName PropertyName,byte InValue,UEnum Enum) { return default; }
	///<summary>Sets the object value of the specified property. Returns true on success, else false.</summary>
	public bool SetValueObject(FName PropertyName,UObject InValue) { return default; }
	///<summary>Sets the class value of the specified property. Returns true on success, else false.</summary>
	public bool SetValueClass(FName PropertyName,UClass InValue) { return default; }
	///<summary>Sets the serialized value of this member. The string should be the serialized representation of the value. Returns true on success, else false.</summary>
	public bool SetValueSerializedString(FName PropertyName,string NewValue) { return default; }
	///<summary>Gets the type of the value stored in the specified property.</summary>
	public EMovieGraphValueType GetValueType(FName PropertyName) { return default; }
	///<summary>Gets the object that defines the enum, struct, or class stored in the specified property.</summary>
	public UObject GetValueTypeObject(FName PropertyName) { return default; }
	///<summary>Gets the container type of the stored value in the specified property.</summary>
	public EMovieGraphContainerType GetValueContainerType(FName PropertyName) { return default; }
	///<summary>Updates an existing variable assignment for the provided graph variable to a new enable state, or adds a new</summary>
	public bool SetVariableAssignmentEnableState(UMovieGraphVariable InGraphVariable,bool bIsEnabled) { return default; }
	///<summary>Gets the enable state of the variable assignment for the provided graph variable. The enable state is provided</summary>
	public bool GetVariableAssignmentEnableState(UMovieGraphVariable InGraphVariable,bool bOutIsEnabled) { return default; }
	///<summary>UpdateGraphVariableOverrides</summary>
	public void UpdateGraphVariableOverrides() {}
	///<summary>The properties managed by this object.</summary>
	public FInstancedPropertyBag Value;
	///<summary>The graph preset associated with the variable overrides.</summary>
	public TSoftObjectPtr<UMovieGraphConfig> GraphPreset;
}
