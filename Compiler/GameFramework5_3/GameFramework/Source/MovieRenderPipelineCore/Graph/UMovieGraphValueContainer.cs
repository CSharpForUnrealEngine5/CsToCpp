namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Holds a generic value, with an API for getting/setting the value, as well as getting/setting its type</summary>
[CppInclude("Graph/MovieGraphValueContainer.h")]
public partial class UMovieGraphValueContainer : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Gets the bool value of the held data. Returns true on success, else false.</summary>
	public bool GetValueBool(bool bOutValue) { return default; }
	///<summary>Gets the byte value of the held data. Returns true on success, else false.</summary>
	public bool GetValueByte(byte OutValue) { return default; }
	///<summary>Gets the int32 value of the held data. Returns true on success, else false.</summary>
	public bool GetValueInt32(int OutValue) { return default; }
	///<summary>Gets the int64 value of the held data. Returns true on success, else false.</summary>
	public bool GetValueInt64(long OutValue) { return default; }
	///<summary>Gets the float value of the held data. Returns true on success, else false.</summary>
	public bool GetValueFloat(float OutValue) { return default; }
	///<summary>Gets the double value of the held data. Returns true on success, else false.</summary>
	public bool GetValueDouble(double OutValue) { return default; }
	///<summary>Gets the FName value of the held data. Returns true on success, else false.</summary>
	public bool GetValueName(FName OutValue) { return default; }
	///<summary>Gets the FString value of the held data. Returns true on success, else false.</summary>
	public bool GetValueString(string OutValue) { return default; }
	///<summary>Gets the FText value of the held data. Returns true on success, else false.</summary>
	public bool GetValueText(FText OutValue) { return default; }
	///<summary>Gets the enum value (for a specific enum) of the held data. Returns true on success, else false.</summary>
	public bool GetValueEnum(byte OutValue,UEnum RequestedEnum/*=nullptr*/) { return default; }
	///<summary>Gets the object value (for a specific class) of the held data. Returns true on success, else false.</summary>
	public bool GetValueObject(UObject OutValue,UClass RequestedClass/*=nullptr*/) { return default; }
	///<summary>Gets the UClass value of the held data. Returns true on success, else false.</summary>
	public bool GetValueClass(UClass OutValue) { return default; }
	///<summary>Gets the serialized string value of the held data.</summary>
	public string GetValueSerializedString() { return default; }
	///<summary>Sets the bool value of the held data. Returns true on success, else false.</summary>
	public bool SetValueBool(bool bInValue) { return default; }
	///<summary>Sets the byte value of the held data. Returns true on success, else false.</summary>
	public bool SetValueByte(byte InValue) { return default; }
	///<summary>Sets the int32 value of the held data. Returns true on success, else false.</summary>
	public bool SetValueInt32(int InValue) { return default; }
	///<summary>Sets the int64 value of the held data. Returns true on success, else false.</summary>
	public bool SetValueInt64(long InValue) { return default; }
	///<summary>Sets the float value of the held data. Returns true on success, else false.</summary>
	public bool SetValueFloat(float InValue) { return default; }
	///<summary>Sets the double value of the held data. Returns true on success, else false.</summary>
	public bool SetValueDouble(double InValue) { return default; }
	///<summary>Sets the FName value of the held data. Returns true on success, else false.</summary>
	public bool SetValueName(FName InValue) { return default; }
	///<summary>Sets the FString value of the held data. Returns true on success, else false.</summary>
	public bool SetValueString(string InValue) { return default; }
	///<summary>Sets the FText value of the held data. Returns true on success, else false.</summary>
	public bool SetValueText(FText InValue) { return default; }
	///<summary>Sets the enum value of the held data. Returns true on success, else false.</summary>
	public bool SetValueEnum(byte InValue,UEnum Enum) { return default; }
	///<summary>Sets the object value of the held data. Returns true on success, else false.</summary>
	public bool SetValueObject(UObject InValue) { return default; }
	///<summary>Sets the class value of the held data. Returns true on success, else false.</summary>
	public bool SetValueClass(UClass InValue) { return default; }
	///<summary>Sets the serialized value of the held data. The string should be the serialized representation of the value. Returns true on success, else false.</summary>
	public bool SetValueSerializedString(string NewValue) { return default; }
	///<summary>Gets the type of the stored data.</summary>
	public EMovieGraphValueType GetValueType() { return default; }
	///<summary>Sets the type of the stored data.</summary>
	public void SetValueType(EMovieGraphValueType ValueType) {}
	///<summary>Gets the object that defines the enum, struct, or class.</summary>
	public UObject GetValueTypeObject() { return default; }
	///<summary>Sets the object that defines the enum, struct, or class.</summary>
	public void SetValueTypeObject(UObject ValueTypeObject) {}
	///<summary>Gets the container type of the stored value.</summary>
	public EMovieGraphContainerType GetValueContainerType() { return default; }
	///<summary>Sets the container type of the stored value.</summary>
	public void SetValueContainerType(EMovieGraphContainerType ContainerType) {}
	///<summary>The value held by this object.</summary>
	public FInstancedPropertyBag Value;
}
