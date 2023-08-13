namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Function library containing methods that should be hoisted onto the test object in Python.</summary>
[CppInclude("PyTest.h")]
public partial class UPyTestObjectLibrary : UBlueprintFunctionLibrary {
	public static UClass StaticClass() {return default;}
	///<summary>IsBoolSet</summary>
	public static bool IsBoolSet(UPyTestObject InObj) { return default; }
	///<summary>GetOtherConstantValue</summary>
	public static int GetOtherConstantValue() { return default; }
}
