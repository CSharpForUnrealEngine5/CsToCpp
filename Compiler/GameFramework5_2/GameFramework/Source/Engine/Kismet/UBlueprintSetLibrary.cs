#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Kismet/BlueprintSetLibrary.h")]
public partial class UBlueprintSetLibrary : UBlueprintFunctionLibrary {
// BlueprintSetLibrary
	public static void Set_Add(TSet<int> TargetSet,int NewItem) {}
	public static void Set_AddItems(TSet<int> TargetSet,TArray<int> NewItems) {}
	public static bool Set_Remove(TSet<int> TargetSet,int Item) { return default; }
	public static bool Set_IsEmpty(TSet<int> TargetSet) { return default; }
	public static bool Set_IsNotEmpty(TSet<int> TargetSet) { return default; }
	public static void Set_RemoveItems(TSet<int> TargetSet,TArray<int> Items) {}
	public static void Set_ToArray(TSet<int> A,TArray<int> Result) {}
	public static void Set_Clear(TSet<int> TargetSet) {}
	public static int Set_Length(TSet<int> TargetSet) { return default; }
	public static bool Set_Contains(TSet<int> TargetSet,int ItemToFind) { return default; }
	public static void Set_Intersection(TSet<int> A,TSet<int> B,TSet<int> Result) {}
	public static void Set_Union(TSet<int> A,TSet<int> B,TSet<int> Result) {}
	public static void Set_Difference(TSet<int> A,TSet<int> B,TSet<int> Result) {}
	public static void SetSetPropertyByName(UObject Object,string PropertyName,TSet<int> Value) {}
}
