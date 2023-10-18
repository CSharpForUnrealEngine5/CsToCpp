namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Object to allow testing of the various UObject features that are exposed to Python wrapped types.</summary>
[CppInclude("PyTest.h")]
public partial class UPyTestObject : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Bool</summary>
	public bool Bool;
	///<summary>Int</summary>
	public int Int;
	///<summary>Float</summary>
	public float Float;
	///<summary>Enum</summary>
	public EPyTestEnum Enum;
	///<summary>String</summary>
	public string String;
	///<summary>Name</summary>
	public FName Name;
	///<summary>Text</summary>
	public FText Text;
	///<summary>FieldPath</summary>
	public object FieldPath;
	///<summary>StructFieldPath</summary>
	public object StructFieldPath;
	///<summary>StringArray</summary>
	public TArray<string> StringArray;
	///<summary>StringSet</summary>
	public TSet<string> StringSet;
	///<summary>StringIntMap</summary>
	public TMap<string,int> StringIntMap;
	///<summary>Delegate</summary>
	public FPyTestDelegate Delegate;
	///<summary>MulticastDelegate</summary>
	public FPyTestMulticastDelegate MulticastDelegate;
	///<summary>Struct</summary>
	public FPyTestStruct Struct;
	///<summary>StructArray</summary>
	public TArray<FPyTestStruct> StructArray;
	///<summary>ChildStruct</summary>
	public FPyTestChildStruct ChildStruct;
	///<summary>BoolInstanceOnly</summary>
	public bool BoolInstanceOnly;
	///<summary>BoolDefaultsOnly</summary>
	public bool BoolDefaultsOnly;
	///<summary>FuncBlueprintImplementable</summary>
	public int FuncBlueprintImplementable(int InValue) { return default; }
	///<summary>FuncBlueprintNative</summary>
	public int FuncBlueprintNative(int InValue) { return default; }
	///<summary>FuncBlueprintNativeRef</summary>
	public void FuncBlueprintNativeRef(FPyTestStruct InOutStruct) {}
	///<summary>CallFuncBlueprintImplementable</summary>
	public int CallFuncBlueprintImplementable(int InValue) { return default; }
	///<summary>CallFuncBlueprintNative</summary>
	public int CallFuncBlueprintNative(int InValue) { return default; }
	///<summary>CallFuncBlueprintNativeRef</summary>
	public void CallFuncBlueprintNativeRef(FPyTestStruct InOutStruct) {}
	///<summary>FuncTakingPyTestStruct</summary>
	public void FuncTakingPyTestStruct(FPyTestStruct InStruct) {}
	///<summary>FuncTakingPyTestChildStruct</summary>
	public void FuncTakingPyTestChildStruct(FPyTestChildStruct InStruct) {}
	///<summary>LegacyFuncTakingPyTestStruct</summary>
	public void LegacyFuncTakingPyTestStruct(FPyTestStruct InStruct) {}
	///<summary>FuncTakingPyTestStructDefault</summary>
	public void FuncTakingPyTestStructDefault(FPyTestStruct InStruct/*=new FPyTestStruct()*/) {}
	///<summary>FuncTakingPyTestDelegate</summary>
	public int FuncTakingPyTestDelegate(FPyTestDelegate InDelegate,int InValue) { return default; }
	///<summary>FuncTakingFieldPath</summary>
	public void FuncTakingFieldPath(object InFieldPath) {}
	///<summary>UHT couldn&#39;t parse any default value for the FieldPath.</summary>
	public int DelegatePropertyCallback(int InValue) { return default; }
	///<summary>MulticastDelegatePropertyCallback</summary>
	public void MulticastDelegatePropertyCallback(string InStr) {}
	///<summary>ReturnArray</summary>
	public static TArray<int> ReturnArray() { return default; }
	///<summary>ReturnSet</summary>
	public static TSet<int> ReturnSet() { return default; }
	///<summary>ReturnMap</summary>
	public static TMap<int,bool> ReturnMap() { return default; }
	///<summary>ReturnFieldPath</summary>
	public static object ReturnFieldPath() { return default; }
	///<summary>EmitScriptError</summary>
	public static void EmitScriptError() {}
	///<summary>EmitScriptWarning</summary>
	public static void EmitScriptWarning() {}
	///<summary>GetConstantValue</summary>
	public static int GetConstantValue() { return default; }
}
