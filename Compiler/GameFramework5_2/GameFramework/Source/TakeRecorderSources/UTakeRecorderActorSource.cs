namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>This Take Recorder Source can record an actor from the World&#39;s properties.</summary>
[CppInclude("TakeRecorderActorSource.h")]
public partial class UTakeRecorderActorSource : UTakeRecorderSource {
	public static UClass StaticClass() {return default;}
	///<summary>Reference to the actor in the world that should have it&#39;s properties recorded.</summary>
	public TSoftObjectPtr<AActor> Target;
	///<summary>Should this actor be recorded as a Possessable in Sequencer? If so the resulting Object Binding</summary>
	public ETakeRecorderActorRecordType RecordType;
	///<summary>Whether to ensure that the parent hierarchy is also recorded. If recording to possessable and the parent is not recorded,</summary>
	public bool bRecordParentHierarchy;
	///<summary>Whether to perform key-reduction algorithms as part of the recording</summary>
	public bool bReduceKeys;
	///<summary>Lists the properties and components on the current actor and whether or not each property will be</summary>
	public UActorRecorderPropertyMap RecordedProperties;
	///<summary>Include only the animation bones/curves that match this list</summary>
	public TArray<string> IncludeAnimationNames;
	///<summary>Exclude all animation bones/curves that match this list</summary>
	public TArray<string> ExcludeAnimationNames;
	///<summary>The level sequence that this source is being recorded into. Set during PreRecording, null after PostRecording.</summary>
	public ULevelSequence TargetLevelSequence;
	///<summary>The root or uppermost level sequence that this source is being recorded into. Set during PreRecording, null after PostRecording.</summary>
	public ULevelSequence RootLevelSequence;
	///<summary>Dynamically created list of settings objects for the different factories that are recording something</summary>
	public TArray<UObject> FactorySettings;
	///<summary>An array of section recorders created during the recording process that are capturing data about the actor/components.</summary>
	public TArray<UMovieSceneTrackRecorder> TrackRecorders;
	///<summary>The parent actor source that generated this actor source (ie. through parenting or as an attached component). Null after PostRecording</summary>
	public UTakeRecorderActorSource ParentSource;
	///<summary>Show Dialog during the (possibly) slow parts of the take recording</summary>
	public bool bShowProgressDialog;
	///<summary>* Add a take recorder source for the given actor.</summary>
	public static UTakeRecorderSource AddSourceForActor(AActor InActor,UTakeRecorderSources InSources) { return default; }
	///<summary>* Remove the given actor from TakeRecorderSources.</summary>
	public static void RemoveActorFromSources(AActor InActor,UTakeRecorderSources InSources) {}
	///<summary>Set the Target actor that we are going to record. Will reset the Recorded Property Map to defaults.</summary>
	public void SetSourceActor(TSoftObjectPtr<AActor> InTarget) {}
	///<summary>GetSourceActor</summary>
	public TSoftObjectPtr<AActor> GetSourceActor() { return default; }
}
