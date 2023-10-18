namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("WorldPartition/WorldPartitionRuntimeCell.h")]
public partial struct FWorldPartitionRuntimeCellObjectMapping {
	public FName Package;
	public FName Path;
	public FActorContainerID ContainerID;
	public FTransform ContainerTransform;
	public FName ContainerPackage;
	public FName WorldPackage;
	public FGuid ActorInstanceGuid;
	public FName LoadedPath;
	public bool bIsEditorOnly;
}
