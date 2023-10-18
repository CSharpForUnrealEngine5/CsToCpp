namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Base class for dynamic virtual properties</summary>
[CppInclude("RCVirtualProperty.h")]
public partial class URCVirtualPropertyBase : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Get Bool value from Virtual Property</summary>
	public bool GetValueBool(bool OutBoolValue) { return default; }
	///<summary>Get Int8 value from Virtual Property</summary>
	public bool GetValueInt8(short OutInt8) { return default; }
	///<summary>Get Byte value from Virtual Property</summary>
	public bool GetValueByte(byte OutByte) { return default; }
	///<summary>Get Int16 value from Virtual Property</summary>
	public bool GetValueInt16(short OutInt16) { return default; }
	///<summary>Get Uint16 value from Virtual Property</summary>
	public bool GetValueUint16(ushort OutUInt16) { return default; }
	///<summary>Get Int32 value from Virtual Property</summary>
	public bool GetValueInt32(int OutInt32) { return default; }
	///<summary>Get Uint32 value from Virtual Property</summary>
	public bool GetValueUInt32(uint OutUInt32) { return default; }
	///<summary>Get Int64 value from Virtual Property</summary>
	public bool GetValueInt64(long OuyInt64) { return default; }
	///<summary>Get Uint64 value from Virtual Property</summary>
	public bool GetValueUint64(ulong OuyUInt64) { return default; }
	///<summary>Get Float value from Virtual Property</summary>
	public bool GetValueFloat(float OutFloat) { return default; }
	///<summary>Get Double value from Virtual Property</summary>
	public bool GetValueDouble(double OutDouble) { return default; }
	///<summary>Get String value from Virtual Property</summary>
	public bool GetValueString(string OutStringValue) { return default; }
	///<summary>Get Name value from Virtual Property</summary>
	public bool GetValueName(FName OutNameValue) { return default; }
	///<summary>Get Text value from Virtual Property</summary>
	public bool GetValueText(FText OutTextValue) { return default; }
	///<summary>Get Numeric value from Virtual Property</summary>
	public bool GetValueNumericInteger(long OutInt64Value) { return default; }
	///<summary>Get Vector value from Virtual Property</summary>
	public bool GetValueVector(FVector OutVector) { return default; }
	///<summary>Get Rotator value from Virtual Property</summary>
	public bool GetValueRotator(FRotator OutRotator) { return default; }
	///<summary>Get Color value from Virtual Property</summary>
	public bool GetValueColor(FColor OutColor) { return default; }
	///<summary>Get Object value from Virtual Property</summary>
	public UObject GetValueObject() { return default; }
	///<summary>Infers correct type internally, fetches value from memory and returns the value as a string</summary>
	public string GetDisplayValueAsString() { return default; }
	///<summary>Set Bool value from Virtual Property</summary>
	public bool SetValueBool(bool InBoolValue) { return default; }
	///<summary>Set Int8 value from Virtual Property</summary>
	public bool SetValueInt8(short InInt8) { return default; }
	///<summary>Set Byte value from Virtual Property</summary>
	public bool SetValueByte(byte InByte) { return default; }
	///<summary>Set Int16 value from Virtual Property</summary>
	public bool SetValueInt16(short InInt16) { return default; }
	///<summary>Set Uint16 value from Virtual Property</summary>
	public bool SetValueUint16(ushort InUInt16) { return default; }
	///<summary>Set Int32 value from Virtual Property</summary>
	public bool SetValueInt32(int InInt32) { return default; }
	///<summary>Set Uint32 value from Virtual Property</summary>
	public bool SetValueUInt32(uint InUInt32) { return default; }
	///<summary>Set Int64 value from Virtual Property</summary>
	public bool SetValueInt64(long InInt64) { return default; }
	///<summary>Set Uint64 value from Virtual Property</summary>
	public bool SetValueUint64(ulong InUInt64) { return default; }
	///<summary>Set Float value from Virtual Property</summary>
	public bool SetValueFloat(float InFloat) { return default; }
	///<summary>Set Double value from Virtual Property</summary>
	public bool SetValueDouble(double InDouble) { return default; }
	///<summary>Set String value from Virtual Property</summary>
	public bool SetValueString(string InStringValue) { return default; }
	///<summary>Set Name value from Virtual Property</summary>
	public bool SetValueName(FName InNameValue) { return default; }
	///<summary>Set Text value from Virtual Property</summary>
	public bool SetValueText(FText InTextValue) { return default; }
	///<summary>Set Numeric value from Virtual Property</summary>
	public bool SetValueNumericInteger(long InInt64Value) { return default; }
	///<summary>Set Vector value from Virtual Property</summary>
	public bool SetValueVector(FVector InVector) { return default; }
	///<summary>Set Rotator value from Virtual Property</summary>
	public bool SetValueRotator(FRotator InRotator) { return default; }
	///<summary>Set Color value from Virtual Property</summary>
	public bool SetValueColor(FColor InColor) { return default; }
	///<summary>Get FProperty Name</summary>
	public FName GetPropertyName() { return default; }
	///<summary>Unique property name</summary>
	public FName PropertyName;
	///<summary>Property Id</summary>
	public FGuid Id;
	///<summary>Property Field Id</summary>
	public FName FieldId;
	///<summary>Pointer to Remote Control Preset</summary>
	public TWeakObjectPtr<URemoteControlPreset> PresetWeakPtr;
	///<summary>User friendly name of the Controller</summary>
	public FName DisplayName;
	///<summary>User configurable Display Index for this Virtual Property (as Logic Controller) when represented as a row in the RC Logic Controllers list</summary>
	public int DisplayIndex;
	///<summary>Metadata</summary>
	public TMap<FName,string> Metadata;
}
