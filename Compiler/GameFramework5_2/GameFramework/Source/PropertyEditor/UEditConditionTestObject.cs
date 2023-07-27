#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("EditConditionParserTests.h")]
///<summary>Test object for edit condition property checks</summary>
public partial class UEditConditionTestObject : UObject {
// EditConditionTestObject
	public bool BoolProperty;
	public EditConditionTestEnum EnumProperty;
	public EditConditionByteEnum ByteEnumProperty;
	public double DoubleProperty;
	public int IntegerProperty;
	public bool UintBitfieldProperty;
	public UObject UObjectPtr;
	public TSoftObjectPtr<UClass> SoftClassPtr;
	public TWeakObjectPtr<UObject> WeakObjectPtr;
	public  void VoidFunction() {}
	public  bool GetBoolFunction() { return default; }
	public  EditConditionTestEnum GetEnumFunction() { return default; }
	public  EditConditionByteEnum GetByteEnumFunction() { return default; }
	public  double GetDoubleFunction() { return default; }
	public  int GetIntegerFunction() { return default; }
	public  byte GetUintBitfieldFunction() { return default; }
	public  UObject GetUObjectPtrFunction() { return default; }
	public  TSoftObjectPtr<UClass> GetSoftClassPtrFunction() { return default; }
	public  TWeakObjectPtr<UObject> GetWeakObjectPtrFunction() { return default; }
	public  void StaticVoidFunction() {}
	public static bool StaticGetBoolFunction() { return default; }
	public static EditConditionTestEnum StaticGetEnumFunction() { return default; }
	public static EditConditionByteEnum StaticGetByteEnumFunction() { return default; }
	public static double StaticGetDoubleFunction() { return default; }
	public static int StaticGetIntegerFunction() { return default; }
	public static byte StaticGetUintBitfieldFunction() { return default; }
	public static UObject StaticGetUObjectPtrFunction() { return default; }
	public static TSoftObjectPtr<UClass> StaticGetSoftClassPtrFunction() { return default; }
	public static TWeakObjectPtr<UObject> StaticGetWeakObjectPtrFunction() { return default; }
}
