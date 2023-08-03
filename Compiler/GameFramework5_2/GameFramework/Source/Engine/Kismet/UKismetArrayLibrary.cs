#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Kismet/KismetArrayLibrary.h")]
public partial class UKismetArrayLibrary : UBlueprintFunctionLibrary {
	public static UClass StaticClass() {return default;}
	///<summary>Add item to array</summary>
	public static int Array_Add(TArray<int> TargetArray,int NewItem) { return default; }
	///<summary>Add item to array (unique)</summary>
	public static int Array_AddUnique(TArray<int> TargetArray,int NewItem) { return default; }
	///<summary>Shuffle (randomize) the elements of an array</summary>
	public static void Array_Shuffle(TArray<int> TargetArray) {}
	///<summary>Checks if two arrays are memberwise identical</summary>
	public static bool Array_Identical(TArray<int> ArrayA,TArray<int> ArrayB) { return default; }
	///<summary>Append an array to another array</summary>
	public static void Array_Append(TArray<int> TargetArray,TArray<int> SourceArray) {}
	///<summary>*Insert item at the given index into the array.</summary>
	public static void Array_Insert(TArray<int> TargetArray,int NewItem,int Index) {}
	///<summary>*Remove item at the given index from the array.</summary>
	public static void Array_Remove(TArray<int> TargetArray,int IndexToRemove) {}
	///<summary>*Remove all instances of item from array.</summary>
	public static bool Array_RemoveItem(TArray<int> TargetArray,int Item) { return default; }
	///<summary>*Clear an array, removes all content</summary>
	public static void Array_Clear(TArray<int> TargetArray) {}
	///<summary>*Resize Array to specified size.</summary>
	public static void Array_Resize(TArray<int> TargetArray,int Size) {}
	///<summary>Reverse the elements of an array</summary>
	public static void Array_Reverse(TArray<int> TargetArray) {}
	///<summary>*Get the number of items in an array</summary>
	public static int Array_Length(TArray<int> TargetArray) { return default; }
	///<summary>*Check if the array is empty</summary>
	public static bool Array_IsEmpty(TArray<int> TargetArray) { return default; }
	///<summary>*Check if the array has any elements</summary>
	public static bool Array_IsNotEmpty(TArray<int> TargetArray) { return default; }
	///<summary>*Get the last valid index into an array</summary>
	public static int Array_LastIndex(TArray<int> TargetArray) { return default; }
	///<summary>*Given an array and an index, returns a copy of the item found at that index</summary>
	public static void Array_Get(TArray<int> TargetArray,int Index,int Item) {}
	///<summary>*Given an array and an index, assigns the item to that array element</summary>
	public static void Array_Set(TArray<int> TargetArray,int Index,int Item,bool bSizeToFit) {}
	///<summary>*Swaps the elements at the specified positions in the specified array</summary>
	public static void Array_Swap(TArray<int> TargetArray,int FirstIndex,int SecondIndex) {}
	///<summary>*Finds the index of the first instance of the item within the array</summary>
	public static int Array_Find(TArray<int> TargetArray,int ItemToFind) { return default; }
	///<summary>*Returns true if the array contains the given item</summary>
	public static bool Array_Contains(TArray<int> TargetArray,int ItemToFind) { return default; }
	///<summary>*Filter an array based on a Class derived from Actor.</summary>
	public static void FilterArray(TArray<AActor> TargetArray,UClass FilterClass,TArray<AActor> FilteredArray) {}
	///<summary>Not exposed to users. Supports setting an array property on an object by name.</summary>
	public static void SetArrayPropertyByName(UObject Object,string PropertyName,TArray<int> Value) {}
	///<summary>*Tests if IndexToTest is valid, i.e. greater than or equal to zero, and less than the number of elements in TargetArray.</summary>
	public static bool Array_IsValidIndex(TArray<int> TargetArray,int IndexToTest) { return default; }
	///<summary>Gets a random item from specified array</summary>
	public static void Array_Random(TArray<int> TargetArray,int OutItem,int OutIndex) {}
	///<summary>Gets a random item from specified array (using random stream)</summary>
	public static void Array_RandomFromStream(TArray<int> TargetArray,FRandomStream RandomStream,int OutItem,int OutIndex) {}
}
