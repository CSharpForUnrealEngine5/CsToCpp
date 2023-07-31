#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Function library containing methods that should be hoisted onto the test struct in Python.</summary>
[CppInclude("PyTest.h")]
public partial class UPyTestStructLibrary : UBlueprintFunctionLibrary {
	///<summary>IsBoolSet</summary>
	public static bool IsBoolSet(FPyTestStruct InStruct) { return default; }
	///<summary>LegacyIsBoolSet</summary>
	public static bool LegacyIsBoolSet(FPyTestStruct InStruct) { return default; }
	///<summary>GetConstantValue</summary>
	public static int GetConstantValue() { return default; }
	///<summary>AddInt</summary>
	public static FPyTestStruct AddInt(FPyTestStruct InStruct,int InValue) { return default; }
	///<summary>AddFloat</summary>
	public static FPyTestStruct AddFloat(FPyTestStruct InStruct,float InValue) { return default; }
	///<summary>AddStr</summary>
	public static FPyTestStruct AddStr(FPyTestStruct InStruct,string InValue) { return default; }
	///<summary>SetBoolMutable</summary>
	public static void SetBoolMutable(FPyTestStruct InStruct) {}
	///<summary>ClearBoolMutable</summary>
	public static void ClearBoolMutable(FPyTestStruct InStruct) {}
	///<summary>SetBoolMutableViaRef</summary>
	public static void SetBoolMutableViaRef(FPyTestStruct InStruct) {}
	///<summary>ClearBoolMutableViaRef</summary>
	public static void ClearBoolMutableViaRef(FPyTestStruct InStruct) {}
}
