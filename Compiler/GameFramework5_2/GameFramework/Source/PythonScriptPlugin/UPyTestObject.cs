#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PyTest.h")]
///<summary>Object to allow testing of the various UObject features that are exposed to Python wrapped types.</summary>
public partial class UPyTestObject : UObject {
// PyTestObject
	public bool Bool;
	public int Int;
	public float Float;
	public EPyTestEnum Enum;
	public string String;
	public string Name;
	public string Text;
	public object FieldPath;
	public object StructFieldPath;
	public TArray<string> StringArray;
	public TSet<string> StringSet;
	public TMap<string,int> StringIntMap;
	public FPyTestDelegate Delegate;
	public FPyTestMulticastDelegate MulticastDelegate;
	public FPyTestStruct Struct;
	public TArray<FPyTestStruct> StructArray;
	public FPyTestChildStruct ChildStruct;
	public bool BoolInstanceOnly;
	public bool BoolDefaultsOnly;
	public  int FuncBlueprintImplementable(int InValue) { return default; }
	public  int FuncBlueprintNative(int InValue) { return default; }
	public  void FuncBlueprintNativeRef(FPyTestStruct InOutStruct) {}
	public  int CallFuncBlueprintImplementable(int InValue) { return default; }
	public  int CallFuncBlueprintNative(int InValue) { return default; }
	public  void CallFuncBlueprintNativeRef(FPyTestStruct InOutStruct) {}
	public  void FuncTakingPyTestStruct(FPyTestStruct InStruct) {}
	public  void FuncTakingPyTestChildStruct(FPyTestChildStruct InStruct) {}
	public  void LegacyFuncTakingPyTestStruct(FPyTestStruct InStruct) {}
	public  void FuncTakingPyTestStructDefault(FPyTestStruct InStruct/*=new FPyTestStruct()*/) {}
	public  int FuncTakingPyTestDelegate(FPyTestDelegate InDelegate,int InValue) { return default; }
	public  void FuncTakingFieldPath(object InFieldPath) {}
	public  int DelegatePropertyCallback(int InValue) { return default; }
	public  void MulticastDelegatePropertyCallback(string InStr) {}
	public static TArray<int> ReturnArray() { return default; }
	public static TSet<int> ReturnSet() { return default; }
	public static TMap<int,bool> ReturnMap() { return default; }
	public static object ReturnFieldPath() { return default; }
	public static void EmitScriptError() {}
	public static void EmitScriptWarning() {}
	public static int GetConstantValue() { return default; }
}
