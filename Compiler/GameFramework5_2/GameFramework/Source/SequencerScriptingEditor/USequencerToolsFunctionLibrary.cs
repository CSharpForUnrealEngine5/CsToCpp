namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>This is a set of helper functions to access various parts of the Sequencer API via Python. Because Sequencer itself is not suitable for exposing, most functionality</summary>
[CppInclude("SequencerTools.h")]
public partial class USequencerToolsFunctionLibrary : UBlueprintFunctionLibrary {
	public static UClass StaticClass() {return default;}
	///<summary>Attempts to render a sequence to movie based on the specified settings. This will automatically detect</summary>
	public static bool RenderMovie(UMovieSceneCapture InCaptureSettings,FOnRenderMovieStopped OnFinishedCallback) { return default; }
	///<summary>Returns if Render to Movie is currently in progress.</summary>
	public static bool IsRenderingMovie() { return default; }
	///<summary>Attempts to cancel an in-progress Render to Movie. Does nothing if there is no render in progress.</summary>
	public static void CancelMovieRender() {}
	///<summary>* Retrieve all objects currently bound to the specified binding identifiers. The sequence will be evaluated in lower bound of the specified range,</summary>
	public static TArray<FSequencerBoundObjects> GetBoundObjects(UWorld InWorld,ULevelSequence InSequence,TArray<FMovieSceneBindingProxy> InBindings,FSequencerScriptingRange InRange) { return default; }
	///<summary>* Get the object bindings for the requested object. The sequence will be evaluated in lower bound of the specified range,</summary>
	public static TArray<FSequencerBoundObjects> GetObjectBindings(UWorld InWorld,ULevelSequence InSequence,TArray<UObject> InObject,FSequencerScriptingRange InRange) { return default; }
	///<summary>* Export Passed in Bindings and Tracks to FBX</summary>
	public static bool ExportLevelSequenceFBX(FSequencerExportFBXParams InParams) { return default; }
	///<summary>* Export Passed in Binding as an Anim Seqquence.</summary>
	public static bool ExportAnimSequence(UWorld World,ULevelSequence Sequence,UAnimSequence AnimSequence,UAnimSeqExportOption ExportOption,FMovieSceneBindingProxy Binding,bool bCreateLink) { return default; }
	///<summary>* Links a LevelSequence&#39;s SkeletalMesh binding to an existing anim sequence.</summary>
	public static bool LinkAnimSequence(ULevelSequence Sequence,UAnimSequence AnimSequence,UAnimSeqExportOption ExportOptions,FMovieSceneBindingProxy Binding) { return default; }
	///<summary>* Clear all linked anim sequences between this level sequence and any linked anim sequences</summary>
	public static void ClearLinkedAnimSequences(ULevelSequence InLevelSequence) {}
	///<summary>* Get the link to the level sequence if it exists on this anim sequence</summary>
	public static UAnimSequenceLevelSequenceLink GetLevelSequenceLinkFromAnimSequence(UAnimSequence InAnimSequence) { return default; }
	///<summary>* Get the links to the anim sequences if they exist on this level sequence</summary>
	public static ULevelSequenceAnimSequenceLink GetAnimSequenceLinkFromLevelSequence(ULevelSequence InLevelSequence) { return default; }
	///<summary>* Import FBX onto Passed in Bindings</summary>
	public static bool ImportLevelSequenceFBX(UWorld InWorld,ULevelSequence InSequence,TArray<FMovieSceneBindingProxy> InBindings,UMovieSceneUserImportFBXSettings InImportFBXSettings,string InImportFilename) { return default; }
	///<summary>Create an event from a previously created blueprint endpoint and a payload. The resulting event should be added only</summary>
	public static FMovieSceneEvent CreateEvent(UMovieSceneSequence InSequence,UMovieSceneEventSectionBase InSection,FSequencerQuickBindingResult InEndpoint,TArray<string> InPayload) { return default; }
	///<summary>Check if an endpoint is valid and can be used to create movie scene event.</summary>
	public static bool IsEventEndpointValid(FSequencerQuickBindingResult InEndpoint) { return default; }
	///<summary>Create a quick binding to an actor&#39;s member method to be used in an event sequence.</summary>
	public static FSequencerQuickBindingResult CreateQuickBinding(UMovieSceneSequence InSequence,UObject InObject,string InFunctionName,bool bCallInEditor) { return default; }
	///<summary>* Import FBX onto a control rig with the specified track name</summary>
	public static bool ImportFBXToControlRig(UWorld World,ULevelSequence InSequence,string ActorWithControlRigTrack,TArray<string> SelectedControlRigNames,UMovieSceneUserImportFBXControlRigSettings ImportFBXControlRigSettings,string ImportFilename) { return default; }
}
