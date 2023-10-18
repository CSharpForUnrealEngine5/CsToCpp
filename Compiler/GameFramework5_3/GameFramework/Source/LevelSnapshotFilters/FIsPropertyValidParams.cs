namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("LevelSnapshotFilterParams.h")]
public partial struct FIsPropertyValidParams {
	public AActor SnapshotActor;
	public AActor LevelActor;
	public FPropertyContainerHandle SnapshotPropertyContainer;
	public FPropertyContainerHandle LevelPropertyContainers;
	public object Property;
	public TArray<string> PropertyPath;
}
