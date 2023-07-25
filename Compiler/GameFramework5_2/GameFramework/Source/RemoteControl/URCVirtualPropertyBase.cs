#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RCVirtualProperty.h")]
///<summary>Base class for dynamic virtual properties</summary>
public partial class URCVirtualPropertyBase : UObject {
// RCVirtualPropertyBase
	public bool GetValueBool(bool OutBoolValue) { return default; }
	public bool GetValueInt8(short OutInt8) { return default; }
	public bool GetValueByte(byte OutByte) { return default; }
	public bool GetValueInt16(short OutInt16) { return default; }
	public bool GetValueUint16(ushort OutUInt16) { return default; }
	public bool GetValueInt32(int OutInt32) { return default; }
	public bool GetValueUInt32(uint OutUInt32) { return default; }
	public bool GetValueInt64(long OuyInt64) { return default; }
	public bool GetValueUint64(ulong OuyUInt64) { return default; }
	public bool GetValueFloat(float OutFloat) { return default; }
	public bool GetValueDouble(double OutDouble) { return default; }
	public bool GetValueString(string OutStringValue) { return default; }
	public bool GetValueName(string OutNameValue) { return default; }
	public bool GetValueText(string OutTextValue) { return default; }
	public bool GetValueNumericInteger(long OutInt64Value) { return default; }
	public bool GetValueVector(FVector OutVector) { return default; }
	public bool GetValueRotator(FRotator OutRotator) { return default; }
	public bool GetValueColor(FColor OutColor) { return default; }
	public string GetDisplayValueAsString() { return default; }
	public bool SetValueBool(bool InBoolValue) { return default; }
	public bool SetValueInt8(short InInt8) { return default; }
	public bool SetValueByte(byte InByte) { return default; }
	public bool SetValueInt16(short InInt16) { return default; }
	public bool SetValueUint16(ushort InUInt16) { return default; }
	public bool SetValueInt32(int InInt32) { return default; }
	public bool SetValueUInt32(uint InUInt32) { return default; }
	public bool SetValueInt64(long InInt64) { return default; }
	public bool SetValueUint64(ulong InUInt64) { return default; }
	public bool SetValueFloat(float InFloat) { return default; }
	public bool SetValueDouble(double InDouble) { return default; }
	public bool SetValueString(string InStringValue) { return default; }
	public bool SetValueName(string InNameValue) { return default; }
	public bool SetValueText(string InTextValue) { return default; }
	public bool SetValueNumericInteger(long InInt64Value) { return default; }
	public bool SetValueVector(FVector InVector) { return default; }
	public bool SetValueRotator(FRotator InRotator) { return default; }
	public bool SetValueColor(FColor InColor) { return default; }
	public string GetPropertyName() { return default; }
	public string PropertyName;
	public FGuid Id;
	public TWeakObjectPtr<URemoteControlPreset> PresetWeakPtr;
	public string DisplayName;
	public int DisplayIndex;
	public TMap<string,string> Metadata;
}
