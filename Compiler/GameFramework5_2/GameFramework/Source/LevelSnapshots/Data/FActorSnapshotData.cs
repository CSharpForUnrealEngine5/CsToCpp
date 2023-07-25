#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Data/ActorSnapshotData.h")]
///<summary>Holds saved actor data. See ActorUtil for operations.</summary>
public partial struct FActorSnapshotData {
// ActorSnapshotData
	public string ActorLabel;
	public FSoftClassPath ActorClass_DEPRECATED;
	public int ClassIndex;
	public FObjectSnapshotData SerializedActorData;
	public FCustomSerializationData CustomActorSerializationData;
	public TMap<int,FComponentSnapshotData> ComponentData;
	public TArray<int> OwnedSubobjects;
	public FActorSnapshotHash Hash;
}
