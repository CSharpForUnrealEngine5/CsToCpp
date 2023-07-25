#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("WorldPartition/WorldPartitionBlueprintLibrary.h")]
public partial class UWorldPartitionBlueprintLibrary : UBlueprintFunctionLibrary {
// WorldPartitionBlueprintLibrary
	public FBox GetEditorWorldBounds() { return default; }
	public FBox GetRuntimeWorldBounds() { return default; }
	public void LoadActors(TArray<FGuid> InActorsToLoad) {}
	public void UnloadActors(TArray<FGuid> InActorsToUnload) {}
	public void PinActors(TArray<FGuid> InActorsToPin) {}
	public void UnpinActors(TArray<FGuid> InActorsToUnpin) {}
	public bool GetActorDescs(TArray<FActorDesc> OutActorDescs) { return default; }
	public bool GetIntersectingActorDescs(FBox InBox,TArray<FActorDesc> OutActorDescs) { return default; }
}
