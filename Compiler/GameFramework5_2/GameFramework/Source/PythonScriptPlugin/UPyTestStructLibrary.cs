#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PyTest.h")]
///<summary>Function library containing methods that should be hoisted onto the test struct in Python.</summary>
public partial class UPyTestStructLibrary : UBlueprintFunctionLibrary {
// PyTestStructLibrary
	public static bool IsBoolSet(FPyTestStruct InStruct) { return default; }
	public static bool LegacyIsBoolSet(FPyTestStruct InStruct) { return default; }
	public static int GetConstantValue() { return default; }
	public static FPyTestStruct AddInt(FPyTestStruct InStruct,int InValue) { return default; }
	public static FPyTestStruct AddFloat(FPyTestStruct InStruct,float InValue) { return default; }
	public static FPyTestStruct AddStr(FPyTestStruct InStruct,string InValue) { return default; }
	public static void SetBoolMutable(FPyTestStruct InStruct) {}
	public static void ClearBoolMutable(FPyTestStruct InStruct) {}
	public static void SetBoolMutableViaRef(FPyTestStruct InStruct) {}
	public static void ClearBoolMutableViaRef(FPyTestStruct InStruct) {}
}
