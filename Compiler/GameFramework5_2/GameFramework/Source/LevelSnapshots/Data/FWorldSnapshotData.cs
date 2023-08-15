namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Holds saved world data. See WorldDataUtil for operations.</summary>
[CppInclude("Data/WorldSnapshotData.h")]
public partial struct FWorldSnapshotData {
	public TWeakObjectPtr<UWorld> SnapshotWorld;
	public TArray<UWorld> SnapshotSublevels;
	public FSnapshotVersionInfo SnapshotVersionInfo;
	public TMap<FSoftClassPath,FClassDefaultObjectSnapshotData> ClassDefaults_DEPRECATED;
	public TArray<FClassSnapshotData> ClassData;
	public TMap<FSoftObjectPath,FActorSnapshotData> ActorData;
	public TArray<FName> SerializedNames;
	public TArray<FSoftObjectPath> SerializedObjectReferences;
	public TMap<int,FSubobjectSnapshotData> Subobjects;
	public TMap<int,FCustomSerializationData> CustomSubobjectSerializationData;
	public TMap<FName,int> NameToIndex;
	public TMap<FSoftObjectPath,int> ReferenceToIndex;
	public TMap<UObject,uint> ArchetypeToClassDataIndex;
}
