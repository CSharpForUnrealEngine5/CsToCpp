namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("WorldPartition/WorldPartitionBlueprintLibrary.h")]
public partial class UWorldPartitionBlueprintLibrary : UBlueprintFunctionLibrary {
	public static UClass StaticClass() {return default;}
	///<summary>Gets the editor world bounds, which includes all actor descriptors.</summary>
	public static FBox GetEditorWorldBounds() { return default; }
	///<summary>Gets the runtime world bounds, which only includes actor descriptors that aren&#39;t editor only.</summary>
	public static FBox GetRuntimeWorldBounds() { return default; }
	///<summary>Load actors</summary>
	public static void LoadActors(TArray<FGuid> InActorsToLoad) {}
	///<summary>Unload actors</summary>
	public static void UnloadActors(TArray<FGuid> InActorsToUnload) {}
	///<summary>Pin actors</summary>
	public static void PinActors(TArray<FGuid> InActorsToPin) {}
	///<summary>Unpin actors</summary>
	public static void UnpinActors(TArray<FGuid> InActorsToUnpin) {}
	///<summary>Gets all the actor descriptors into the provided array, recursing into actor containers.</summary>
	public static bool GetActorDescs(TArray<FActorDesc> OutActorDescs) { return default; }
	///<summary>Gets all the actor descriptors intersecting the provided box into the provided array, recursing into actor containers.</summary>
	public static bool GetIntersectingActorDescs(FBox InBox,TArray<FActorDesc> OutActorDescs) { return default; }
	///<summary>Returns the Data Layer Manager for this object.</summary>
	public static UDataLayerManager GetDataLayerManager(UObject WorldContextObject) { return default; }
}
