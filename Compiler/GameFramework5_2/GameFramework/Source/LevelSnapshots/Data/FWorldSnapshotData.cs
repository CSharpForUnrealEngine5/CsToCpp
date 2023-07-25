#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Data/WorldSnapshotData.h")]
///<summary>Holds saved world data. See WorldDataUtil for operations.</summary>
public partial struct FWorldSnapshotData {
// WorldSnapshotData
	public TWeakObjectPtr<UWorld> SnapshotWorld;
	public TArray<UWorld> SnapshotSublevels;
	public FSnapshotVersionInfo SnapshotVersionInfo;
	public TMap<FSoftClassPath,FClassDefaultObjectSnapshotData> ClassDefaults_DEPRECATED;
	public TArray<FClassSnapshotData> ClassData;
	public TMap<FSoftObjectPath,FActorSnapshotData> ActorData;
	public TArray<string> SerializedNames;
	public TArray<FSoftObjectPath> SerializedObjectReferences;
	public TMap<int,FSubobjectSnapshotData> Subobjects;
	public TMap<int,FCustomSerializationData> CustomSubobjectSerializationData;
	public TMap<string,int> NameToIndex;
	public TMap<FSoftObjectPath,int> ReferenceToIndex;
	public TMap<UObject,uint> ArchetypeToClassDataIndex;
}
