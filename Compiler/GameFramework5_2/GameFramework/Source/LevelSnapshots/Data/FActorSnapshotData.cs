#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Holds saved actor data. See ActorUtil for operations.</summary>
[CppInclude("Data/ActorSnapshotData.h")]
public partial struct FActorSnapshotData {
	public string ActorLabel;
	public FSoftClassPath ActorClass_DEPRECATED;
	public int ClassIndex;
	public FObjectSnapshotData SerializedActorData;
	public FCustomSerializationData CustomActorSerializationData;
	public TMap<int,FComponentSnapshotData> ComponentData;
	public TArray<int> OwnedSubobjects;
	public FActorSnapshotHash Hash;
}
