namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("StructUtilsFunctionLibrary.h")]
public partial class UStructUtilsFunctionLibrary : UBlueprintFunctionLibrary {
	public static UClass StaticClass() {return default;}
	///<summary>Create a new InstancedStruct from the given source value.</summary>
	public static FInstancedStruct MakeInstancedStruct(int Value) { return default; }
	///<summary>Sets the value of InstancedStruct from the given source value.</summary>
	public static void SetInstancedStructValue(FInstancedStruct InstancedStruct,int Value) {}
	///<summary>Retrieves data from an InstancedStruct if it matches the output type.</summary>
	public static void GetInstancedStructValue(EStructUtilsResult ExecResult,FInstancedStruct InstancedStruct,int Value) {}
	///<summary>Resets an InstancedStruct.</summary>
	public static void Reset(FInstancedStruct InstancedStruct,UScriptStruct StructType/*=nullptr*/) {}
	///<summary>Checks whether an InstancedStruct contains value.</summary>
	public static EStructUtilsResult IsInstancedStructValid(FInstancedStruct InstancedStruct) { return default; }
	///<summary>Checks whether two InstancedStructs (and the values contained within) are equal.</summary>
	public static bool EqualEqual_InstancedStruct(FInstancedStruct A,FInstancedStruct B) { return default; }
	///<summary>Checks whether two InstancedStructs are not equal.</summary>
	public static bool NotEqual_InstancedStruct(FInstancedStruct A,FInstancedStruct B) { return default; }
	///<summary>Checks whether the InstancedStruct contains value.</summary>
	public static bool IsValid_InstancedStruct(FInstancedStruct InstancedStruct) { return default; }
}
