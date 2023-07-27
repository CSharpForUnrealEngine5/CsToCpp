#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Kismet/BlueprintMapLibrary.h")]
public partial class UBlueprintMapLibrary : UBlueprintFunctionLibrary {
// BlueprintMapLibrary
	public static void Map_Add(TMap<int,int> TargetMap,int Key,int Value) {}
	public static bool Map_Remove(TMap<int,int> TargetMap,int Key) { return default; }
	public static bool Map_Find(TMap<int,int> TargetMap,int Key,int Value) { return default; }
	public static bool Map_Contains(TMap<int,int> TargetMap,int Key) { return default; }
	public static void Map_Keys(TMap<int,int> TargetMap,TArray<int> Keys) {}
	public static void Map_Values(TMap<int,int> TargetMap,TArray<int> Values) {}
	public static int Map_Length(TMap<int,int> TargetMap) { return default; }
	public static bool Map_IsEmpty(TMap<int,int> TargetMap) { return default; }
	public static bool Map_IsNotEmpty(TMap<int,int> TargetMap) { return default; }
	public static void Map_Clear(TMap<int,int> TargetMap) {}
	public static void SetMapPropertyByName(UObject Object,string PropertyName,TMap<int,int> Value) {}
}
