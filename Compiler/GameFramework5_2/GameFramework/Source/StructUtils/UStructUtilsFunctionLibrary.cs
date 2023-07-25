#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("StructUtilsFunctionLibrary.h")]
public partial class UStructUtilsFunctionLibrary : UBlueprintFunctionLibrary {
// StructUtilsFunctionLibrary
	public FInstancedStruct MakeInstancedStruct(int Value) { return default; }
	public void SetInstancedStructValue(FInstancedStruct InstancedStruct,int Value) {}
	public void GetInstancedStructValue(EStructUtilsResult ExecResult,FInstancedStruct InstancedStruct,int Value) {}
	public void Reset(FInstancedStruct InstancedStruct,UObject StructType/*=nullptr*/) {}
	public EStructUtilsResult IsInstancedStructValid(FInstancedStruct InstancedStruct) { return default; }
	public bool EqualEqual_InstancedStruct(FInstancedStruct A,FInstancedStruct B) { return default; }
	public bool NotEqual_InstancedStruct(FInstancedStruct A,FInstancedStruct B) { return default; }
	public bool IsValid_InstancedStruct(FInstancedStruct InstancedStruct) { return default; }
}
