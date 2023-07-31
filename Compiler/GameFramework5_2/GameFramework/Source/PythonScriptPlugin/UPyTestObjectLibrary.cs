#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Function library containing methods that should be hoisted onto the test object in Python.</summary>
[CppInclude("PyTest.h")]
public partial class UPyTestObjectLibrary : UBlueprintFunctionLibrary {
	///<summary>IsBoolSet</summary>
	public static bool IsBoolSet(UPyTestObject InObj) { return default; }
	///<summary>GetOtherConstantValue</summary>
	public static int GetOtherConstantValue() { return default; }
}
