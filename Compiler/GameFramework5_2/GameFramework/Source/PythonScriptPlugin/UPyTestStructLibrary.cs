#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PyTest.h")]
///<summary>Function library containing methods that should be hoisted onto the test struct in Python.</summary>
public partial class UPyTestStructLibrary : UBlueprintFunctionLibrary {
// PyTestStructLibrary
	public bool IsBoolSet(FPyTestStruct InStruct) { return default; }
	public bool LegacyIsBoolSet(FPyTestStruct InStruct) { return default; }
	public int GetConstantValue() { return default; }
	public FPyTestStruct AddInt(FPyTestStruct InStruct,int InValue) { return default; }
	public FPyTestStruct AddFloat(FPyTestStruct InStruct,float InValue) { return default; }
	public FPyTestStruct AddStr(FPyTestStruct InStruct,string InValue) { return default; }
	public void SetBoolMutable(FPyTestStruct InStruct) {}
	public void ClearBoolMutable(FPyTestStruct InStruct) {}
	public void SetBoolMutableViaRef(FPyTestStruct InStruct) {}
	public void ClearBoolMutableViaRef(FPyTestStruct InStruct) {}
}
