namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Kismet/BlueprintMapLibrary.h")]
public partial class UBlueprintMapLibrary : UBlueprintFunctionLibrary {
	public static UClass StaticClass() {return default;}
	///<summary>Adds a key and value to the map. If something already uses the provided key it will be overwritten with the new value.</summary>
	public static void Map_Add(TMap<int,int> TargetMap,int Key,int Value) {}
	///<summary>Removes a key and its associated value from the map.</summary>
	public static bool Map_Remove(TMap<int,int> TargetMap,int Key) { return default; }
	///<summary>Finds the value associated with the provided Key</summary>
	public static bool Map_Find(TMap<int,int> TargetMap,int Key,int Value) { return default; }
	///<summary>Checks whether key is in a provided Map</summary>
	public static bool Map_Contains(TMap<int,int> TargetMap,int Key) { return default; }
	///<summary>Outputs an array of all keys present in the map</summary>
	public static void Map_Keys(TMap<int,int> TargetMap,TArray<int> Keys) {}
	///<summary>Outputs an array of all values present in the map</summary>
	public static void Map_Values(TMap<int,int> TargetMap,TArray<int> Values) {}
	///<summary>Determines the number of entries in a provided Map</summary>
	public static int Map_Length(TMap<int,int> TargetMap) { return default; }
	///<summary>Check if the map does not have any entires</summary>
	public static bool Map_IsEmpty(TMap<int,int> TargetMap) { return default; }
	///<summary>Check if the map has any entries</summary>
	public static bool Map_IsNotEmpty(TMap<int,int> TargetMap) { return default; }
	///<summary>Clears a map of all entries, resetting it to empty</summary>
	public static void Map_Clear(TMap<int,int> TargetMap) {}
	///<summary>Not exposed to users. Supports setting a map property on an object by name.</summary>
	public static void SetMapPropertyByName(UObject Object,FName PropertyName,TMap<int,int> Value) {}
}
