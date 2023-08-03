#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Test object for edit condition property checks</summary>
[CppInclude("EditConditionParserTests.h")]
public partial class UEditConditionTestObject : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>BoolProperty</summary>
	public bool BoolProperty;
	///<summary>EnumProperty</summary>
	public EditConditionTestEnum EnumProperty;
	///<summary>ByteEnumProperty</summary>
	public EditConditionByteEnum ByteEnumProperty;
	///<summary>DoubleProperty</summary>
	public double DoubleProperty;
	///<summary>IntegerProperty</summary>
	public int IntegerProperty;
	///<summary>UintBitfieldProperty</summary>
	public bool UintBitfieldProperty;
	///<summary>UObjectPtr</summary>
	public UObject UObjectPtr;
	///<summary>SoftClassPtr</summary>
	public TSoftObjectPtr<UClass> SoftClassPtr;
	///<summary>WeakObjectPtr</summary>
	public TWeakObjectPtr<UObject> WeakObjectPtr;
	///<summary>Used in test cases that should fail, should not be able to execute a void function in edit condition</summary>
	public  void VoidFunction() {}
	///<summary>GetBoolFunction</summary>
	public  bool GetBoolFunction() { return default; }
	///<summary>GetEnumFunction</summary>
	public  EditConditionTestEnum GetEnumFunction() { return default; }
	///<summary>GetByteEnumFunction</summary>
	public  EditConditionByteEnum GetByteEnumFunction() { return default; }
	///<summary>GetDoubleFunction</summary>
	public  double GetDoubleFunction() { return default; }
	///<summary>GetIntegerFunction</summary>
	public  int GetIntegerFunction() { return default; }
	///<summary>GetUintBitfieldFunction</summary>
	public  byte GetUintBitfieldFunction() { return default; }
	///<summary>GetUObjectPtrFunction</summary>
	public  UObject GetUObjectPtrFunction() { return default; }
	///<summary>GetSoftClassPtrFunction</summary>
	public  TSoftObjectPtr<UClass> GetSoftClassPtrFunction() { return default; }
	///<summary>GetWeakObjectPtrFunction</summary>
	public  TWeakObjectPtr<UObject> GetWeakObjectPtrFunction() { return default; }
	///<summary>Used in test cases that should fail, should not be able to execute a void function in edit condition</summary>
	public  void StaticVoidFunction() {}
	///<summary>StaticGetBoolFunction</summary>
	public static bool StaticGetBoolFunction() { return default; }
	///<summary>StaticGetEnumFunction</summary>
	public static EditConditionTestEnum StaticGetEnumFunction() { return default; }
	///<summary>StaticGetByteEnumFunction</summary>
	public static EditConditionByteEnum StaticGetByteEnumFunction() { return default; }
	///<summary>StaticGetDoubleFunction</summary>
	public static double StaticGetDoubleFunction() { return default; }
	///<summary>StaticGetIntegerFunction</summary>
	public static int StaticGetIntegerFunction() { return default; }
	///<summary>StaticGetUintBitfieldFunction</summary>
	public static byte StaticGetUintBitfieldFunction() { return default; }
	///<summary>StaticGetUObjectPtrFunction</summary>
	public static UObject StaticGetUObjectPtrFunction() { return default; }
	///<summary>StaticGetSoftClassPtrFunction</summary>
	public static TSoftObjectPtr<UClass> StaticGetSoftClassPtrFunction() { return default; }
	///<summary>StaticGetWeakObjectPtrFunction</summary>
	public static TWeakObjectPtr<UObject> StaticGetWeakObjectPtrFunction() { return default; }
}
