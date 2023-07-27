#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Kismet/KismetArrayLibrary.h")]
public partial class UKismetArrayLibrary : UBlueprintFunctionLibrary {
// KismetArrayLibrary
	public static int Array_Add(TArray<int> TargetArray,int NewItem) { return default; }
	public static int Array_AddUnique(TArray<int> TargetArray,int NewItem) { return default; }
	public static void Array_Shuffle(TArray<int> TargetArray) {}
	public static bool Array_Identical(TArray<int> ArrayA,TArray<int> ArrayB) { return default; }
	public static void Array_Append(TArray<int> TargetArray,TArray<int> SourceArray) {}
	public static void Array_Insert(TArray<int> TargetArray,int NewItem,int Index) {}
	public static void Array_Remove(TArray<int> TargetArray,int IndexToRemove) {}
	public static bool Array_RemoveItem(TArray<int> TargetArray,int Item) { return default; }
	public static void Array_Clear(TArray<int> TargetArray) {}
	public static void Array_Resize(TArray<int> TargetArray,int Size) {}
	public static void Array_Reverse(TArray<int> TargetArray) {}
	public static int Array_Length(TArray<int> TargetArray) { return default; }
	public static bool Array_IsEmpty(TArray<int> TargetArray) { return default; }
	public static bool Array_IsNotEmpty(TArray<int> TargetArray) { return default; }
	public static int Array_LastIndex(TArray<int> TargetArray) { return default; }
	public static void Array_Get(TArray<int> TargetArray,int Index,int Item) {}
	public static void Array_Set(TArray<int> TargetArray,int Index,int Item,bool bSizeToFit) {}
	public static void Array_Swap(TArray<int> TargetArray,int FirstIndex,int SecondIndex) {}
	public static int Array_Find(TArray<int> TargetArray,int ItemToFind) { return default; }
	public static bool Array_Contains(TArray<int> TargetArray,int ItemToFind) { return default; }
	public static void FilterArray(TArray<AActor> TargetArray,UClass FilterClass,TArray<AActor> FilteredArray) {}
	public static void SetArrayPropertyByName(UObject Object,string PropertyName,TArray<int> Value) {}
	public static bool Array_IsValidIndex(TArray<int> TargetArray,int IndexToTest) { return default; }
	public static void Array_Random(TArray<int> TargetArray,int OutItem,int OutIndex) {}
	public static void Array_RandomFromStream(TArray<int> TargetArray,FRandomStream RandomStream,int OutItem,int OutIndex) {}
}
