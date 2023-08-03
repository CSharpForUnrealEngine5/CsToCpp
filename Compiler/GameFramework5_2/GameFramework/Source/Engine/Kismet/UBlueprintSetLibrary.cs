#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Kismet/BlueprintSetLibrary.h")]
public partial class UBlueprintSetLibrary : UBlueprintFunctionLibrary {
	public static UClass StaticClass() {return default;}
	///<summary>Adds item to set</summary>
	public static void Set_Add(TSet<int> TargetSet,int NewItem) {}
	///<summary>Adds all elements from an Array to a Set</summary>
	public static void Set_AddItems(TSet<int> TargetSet,TArray<int> NewItems) {}
	///<summary>Remove item from set. Output value indicates if something was actually removed. False</summary>
	public static bool Set_Remove(TSet<int> TargetSet,int Item) { return default; }
	///<summary>Check if the set is empty</summary>
	public static bool Set_IsEmpty(TSet<int> TargetSet) { return default; }
	///<summary>Check if the set has any elements</summary>
	public static bool Set_IsNotEmpty(TSet<int> TargetSet) { return default; }
	///<summary>Removes all elements in an Array from a set.</summary>
	public static void Set_RemoveItems(TSet<int> TargetSet,TArray<int> Items) {}
	///<summary>Outputs an Array containing copies of the entries of a Set.</summary>
	public static void Set_ToArray(TSet<int> A,TArray<int> Result) {}
	///<summary>Clear a set, removes all content.</summary>
	public static void Set_Clear(TSet<int> TargetSet) {}
	///<summary>Get the number of items in a set.</summary>
	public static int Set_Length(TSet<int> TargetSet) { return default; }
	///<summary>Returns true if the set contains the given item.</summary>
	public static bool Set_Contains(TSet<int> TargetSet,int ItemToFind) { return default; }
	///<summary>Assigns Result to the intersection of Set A and Set B. That is, Result will contain</summary>
	public static void Set_Intersection(TSet<int> A,TSet<int> B,TSet<int> Result) {}
	///<summary>Assigns Result to the union of two sets, A and B. That is, Result will contain</summary>
	public static void Set_Union(TSet<int> A,TSet<int> B,TSet<int> Result) {}
	///<summary>Assigns Result to the relative difference of two sets, A and B. That is, Result will</summary>
	public static void Set_Difference(TSet<int> A,TSet<int> B,TSet<int> Result) {}
	///<summary>Not exposed to users. Supports setting a set property on an object by name.</summary>
	public static void SetSetPropertyByName(UObject Object,string PropertyName,TSet<int> Value) {}
}
