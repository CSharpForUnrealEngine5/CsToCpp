#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("WorldPartition/WorldPartitionBlueprintLibrary.h")]
public partial class UWorldPartitionBlueprintLibrary : UBlueprintFunctionLibrary {
// WorldPartitionBlueprintLibrary
	public static FBox GetEditorWorldBounds() { return default; }
	public static FBox GetRuntimeWorldBounds() { return default; }
	public static void LoadActors(TArray<FGuid> InActorsToLoad) {}
	public static void UnloadActors(TArray<FGuid> InActorsToUnload) {}
	public static void PinActors(TArray<FGuid> InActorsToPin) {}
	public static void UnpinActors(TArray<FGuid> InActorsToUnpin) {}
	public static bool GetActorDescs(TArray<FActorDesc> OutActorDescs) { return default; }
	public static bool GetIntersectingActorDescs(FBox InBox,TArray<FActorDesc> OutActorDescs) { return default; }
}
