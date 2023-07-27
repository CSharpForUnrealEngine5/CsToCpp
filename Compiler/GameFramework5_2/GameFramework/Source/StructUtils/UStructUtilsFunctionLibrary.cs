#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("StructUtilsFunctionLibrary.h")]
public partial class UStructUtilsFunctionLibrary : UBlueprintFunctionLibrary {
// StructUtilsFunctionLibrary
	public static FInstancedStruct MakeInstancedStruct(int Value) { return default; }
	public static void SetInstancedStructValue(FInstancedStruct InstancedStruct,int Value) {}
	public static void GetInstancedStructValue(EStructUtilsResult ExecResult,FInstancedStruct InstancedStruct,int Value) {}
	public static void Reset(FInstancedStruct InstancedStruct,UScriptStruct StructType/*=nullptr*/) {}
	public static EStructUtilsResult IsInstancedStructValid(FInstancedStruct InstancedStruct) { return default; }
	public static bool EqualEqual_InstancedStruct(FInstancedStruct A,FInstancedStruct B) { return default; }
	public static bool NotEqual_InstancedStruct(FInstancedStruct A,FInstancedStruct B) { return default; }
	public static bool IsValid_InstancedStruct(FInstancedStruct InstancedStruct) { return default; }
}
