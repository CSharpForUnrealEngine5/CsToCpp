#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Tests/PropertyPathHelpersTest.h")]
public partial class UPropertyPathTestObject : UObject {
// PropertyPathTestObject
	public bool Bool;
	public byte EnumOne;
	public byte EnumTwo;
	public byte EnumThree;
	public byte EnumFour;
	public int Integer;
	public string String;
	public float Float;
	public FPropertyPathTestStruct Struct;
	public FPropertyPathTestStruct StructRef;
	public FPropertyPathTestStruct StructConstRef;
	public UPropertyPathTestObject InnerObject;
	public  void SetFloat(float InFloat) {}
	public  float GetFloat() { return default; }
	public  void SetStruct(FPropertyPathTestStruct InStruct) {}
	public  FPropertyPathTestStruct GetStruct() { return default; }
	public  void SetStructRef(FPropertyPathTestStruct InStruct) {}
	public  FPropertyPathTestStruct GetStructRef() { return default; }
	public  void SetStructConstRef(FPropertyPathTestStruct InStruct) {}
	public  FPropertyPathTestStruct GetStructConstRef() { return default; }
}
