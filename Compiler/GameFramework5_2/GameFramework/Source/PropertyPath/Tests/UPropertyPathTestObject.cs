namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Tests/PropertyPathHelpersTest.h")]
public partial class UPropertyPathTestObject : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Bool</summary>
	public bool Bool;
	///<summary>EnumOne</summary>
	public EPropertyPathTestEnum EnumOne;
	///<summary>EnumTwo</summary>
	public EPropertyPathTestEnum EnumTwo;
	///<summary>EnumThree</summary>
	public EPropertyPathTestEnum EnumThree;
	///<summary>EnumFour</summary>
	public EPropertyPathTestEnum EnumFour;
	///<summary>Integer</summary>
	public int Integer;
	///<summary>String</summary>
	public string String;
	///<summary>Float</summary>
	public float Float;
	///<summary>Struct</summary>
	public FPropertyPathTestStruct Struct;
	///<summary>StructRef</summary>
	public FPropertyPathTestStruct StructRef;
	///<summary>StructConstRef</summary>
	public FPropertyPathTestStruct StructConstRef;
	///<summary>InnerObject</summary>
	public UPropertyPathTestObject InnerObject;
	///<summary>SetFloat</summary>
	public void SetFloat(float InFloat) {}
	///<summary>GetFloat</summary>
	public float GetFloat() { return default; }
	///<summary>SetStruct</summary>
	public void SetStruct(FPropertyPathTestStruct InStruct) {}
	///<summary>GetStruct</summary>
	public FPropertyPathTestStruct GetStruct() { return default; }
	///<summary>SetStructRef</summary>
	public void SetStructRef(FPropertyPathTestStruct InStruct) {}
	///<summary>GetStructRef</summary>
	public FPropertyPathTestStruct GetStructRef() { return default; }
	///<summary>SetStructConstRef</summary>
	public void SetStructConstRef(FPropertyPathTestStruct InStruct) {}
	///<summary>GetStructConstRef</summary>
	public FPropertyPathTestStruct GetStructConstRef() { return default; }
}
