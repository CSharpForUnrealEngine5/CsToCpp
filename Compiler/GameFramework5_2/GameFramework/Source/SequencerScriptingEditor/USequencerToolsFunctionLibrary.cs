#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("SequencerTools.h")]
///<summary>This is a set of helper functions to access various parts of the Sequencer API via Python. Because Sequencer itself is not suitable for exposing, most functionality</summary>
public partial class USequencerToolsFunctionLibrary : UBlueprintFunctionLibrary {
// SequencerToolsFunctionLibrary
	public bool RenderMovie(UObject InCaptureSettings,FOnRenderMovieStopped OnFinishedCallback) { return default; }
	public bool IsRenderingMovie() { return default; }
	public void CancelMovieRender() {}
	public TArray<FSequencerBoundObjects> GetBoundObjects(UObject InWorld,UObject InSequence,TArray<FMovieSceneBindingProxy> InBindings,FSequencerScriptingRange InRange) { return default; }
	public TArray<FSequencerBoundObjects> GetObjectBindings(UObject InWorld,UObject InSequence,TArray<UObject> InObject,FSequencerScriptingRange InRange) { return default; }
	public bool ExportLevelSequenceFBX(FSequencerExportFBXParams InParams) { return default; }
	public bool ExportAnimSequence(UObject World,UObject Sequence,UObject AnimSequence,UObject ExportOption,FMovieSceneBindingProxy Binding,bool bCreateLink) { return default; }
	public bool LinkAnimSequence(UObject Sequence,UObject AnimSequence,UObject ExportOptions,FMovieSceneBindingProxy Binding) { return default; }
	public void ClearLinkedAnimSequences(UObject InLevelSequence) {}
	public UObject GetLevelSequenceLinkFromAnimSequence(UObject InAnimSequence) { return default; }
	public UObject GetAnimSequenceLinkFromLevelSequence(UObject InLevelSequence) { return default; }
	public bool ImportLevelSequenceFBX(UObject InWorld,UObject InSequence,TArray<FMovieSceneBindingProxy> InBindings,UObject InImportFBXSettings,string InImportFilename) { return default; }
	public FMovieSceneEvent CreateEvent(UObject InSequence,UObject InSection,FSequencerQuickBindingResult InEndpoint,TArray<string> InPayload) { return default; }
	public bool IsEventEndpointValid(FSequencerQuickBindingResult InEndpoint) { return default; }
	public FSequencerQuickBindingResult CreateQuickBinding(UObject InSequence,UObject InObject,string InFunctionName,bool bCallInEditor) { return default; }
	public bool ImportFBXToControlRig(UObject World,UObject InSequence,string ActorWithControlRigTrack,TArray<string> SelectedControlRigNames,UObject ImportFBXControlRigSettings,string ImportFilename) { return default; }
}
