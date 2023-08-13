namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Snapshot of an actor descriptor, which represents the state of an actor on disk.</summary>
[CppInclude("WorldPartition/WorldPartitionBlueprintLibrary.h")]
public partial struct FActorDesc {
	public FGuid Guid;
	public FSoftObjectPath Class;
	public string Name;
	public string Label;
	public FBox Bounds;
	public string RuntimeGrid;
	public bool bIsSpatiallyLoaded;
	public bool bActorIsEditorOnly;
	public string ActorPackage;
	public string ActorPath;
}
