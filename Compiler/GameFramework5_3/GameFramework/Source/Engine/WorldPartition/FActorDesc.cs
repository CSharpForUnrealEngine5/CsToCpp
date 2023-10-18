namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Snapshot of an actor descriptor, which represents the state of an actor on disk.</summary>
[CppInclude("WorldPartition/WorldPartitionBlueprintLibrary.h")]
public partial struct FActorDesc {
	public FGuid Guid;
	public UClass NativeClass;
	public FSoftObjectPath Class;
	public FName Name;
	public FName Label;
	public FBox Bounds;
	public FName RuntimeGrid;
	public bool bIsSpatiallyLoaded;
	public bool bActorIsEditorOnly;
	public FName ActorPackage;
	public FName ActorPath;
	public TArray<FSoftObjectPath> DataLayerAssets;
}
