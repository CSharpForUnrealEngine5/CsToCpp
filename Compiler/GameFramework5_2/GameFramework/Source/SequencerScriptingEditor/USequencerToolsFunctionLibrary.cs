#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("SequencerTools.h")]
///<summary>This is a set of helper functions to access various parts of the Sequencer API via Python. Because Sequencer itself is not suitable for exposing, most functionality</summary>
public partial class USequencerToolsFunctionLibrary : UBlueprintFunctionLibrary {
// SequencerToolsFunctionLibrary
	public static bool RenderMovie(UMovieSceneCapture InCaptureSettings,FOnRenderMovieStopped OnFinishedCallback) { return default; }
	public static bool IsRenderingMovie() { return default; }
	public static void CancelMovieRender() {}
	public static TArray<FSequencerBoundObjects> GetBoundObjects(UWorld InWorld,ULevelSequence InSequence,TArray<FMovieSceneBindingProxy> InBindings,FSequencerScriptingRange InRange) { return default; }
	public static TArray<FSequencerBoundObjects> GetObjectBindings(UWorld InWorld,ULevelSequence InSequence,TArray<UObject> InObject,FSequencerScriptingRange InRange) { return default; }
	public static bool ExportLevelSequenceFBX(FSequencerExportFBXParams InParams) { return default; }
	public static bool ExportAnimSequence(UWorld World,ULevelSequence Sequence,UAnimSequence AnimSequence,UAnimSeqExportOption ExportOption,FMovieSceneBindingProxy Binding,bool bCreateLink) { return default; }
	public static bool LinkAnimSequence(ULevelSequence Sequence,UAnimSequence AnimSequence,UAnimSeqExportOption ExportOptions,FMovieSceneBindingProxy Binding) { return default; }
	public static void ClearLinkedAnimSequences(ULevelSequence InLevelSequence) {}
	public static UAnimSequenceLevelSequenceLink GetLevelSequenceLinkFromAnimSequence(UAnimSequence InAnimSequence) { return default; }
	public static ULevelSequenceAnimSequenceLink GetAnimSequenceLinkFromLevelSequence(ULevelSequence InLevelSequence) { return default; }
	public static bool ImportLevelSequenceFBX(UWorld InWorld,ULevelSequence InSequence,TArray<FMovieSceneBindingProxy> InBindings,UMovieSceneUserImportFBXSettings InImportFBXSettings,string InImportFilename) { return default; }
	public static FMovieSceneEvent CreateEvent(UMovieSceneSequence InSequence,UMovieSceneEventSectionBase InSection,FSequencerQuickBindingResult InEndpoint,TArray<string> InPayload) { return default; }
	public static bool IsEventEndpointValid(FSequencerQuickBindingResult InEndpoint) { return default; }
	public static FSequencerQuickBindingResult CreateQuickBinding(UMovieSceneSequence InSequence,UObject InObject,string InFunctionName,bool bCallInEditor) { return default; }
	public static bool ImportFBXToControlRig(UWorld World,ULevelSequence InSequence,string ActorWithControlRigTrack,TArray<string> SelectedControlRigNames,UMovieSceneUserImportFBXControlRigSettings ImportFBXControlRigSettings,string ImportFilename) { return default; }
}
