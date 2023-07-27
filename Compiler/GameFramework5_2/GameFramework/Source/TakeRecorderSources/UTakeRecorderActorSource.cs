#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("TakeRecorderActorSource.h")]
///<summary>This Take Recorder Source can record an actor from the World's properties.</summary>
public partial class UTakeRecorderActorSource : UTakeRecorderSource {
// TakeRecorderActorSource
	public TSoftObjectPtr<AActor> Target;
	public ETakeRecorderActorRecordType RecordType;
	public bool bRecordParentHierarchy;
	public bool bReduceKeys;
	public UActorRecorderPropertyMap RecordedProperties;
	public TArray<string> IncludeAnimationNames;
	public TArray<string> ExcludeAnimationNames;
	public ULevelSequence TargetLevelSequence;
	public ULevelSequence RootLevelSequence;
	public TArray<UObject> FactorySettings;
	public TArray<UMovieSceneTrackRecorder> TrackRecorders;
	public UTakeRecorderActorSource ParentSource;
	public bool bShowProgressDialog;
	public static UTakeRecorderSource AddSourceForActor(AActor InActor,UTakeRecorderSources InSources) { return default; }
	public static void RemoveActorFromSources(AActor InActor,UTakeRecorderSources InSources) {}
	public  void SetSourceActor(TSoftObjectPtr<AActor> InTarget) {}
	public  TSoftObjectPtr<AActor> GetSourceActor() { return default; }
}
