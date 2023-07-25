#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Niagara/Sequencer/MovieSceneNiagaraCacheTrack.h")]
///<summary>Handles animation of NiagaraCache</summary>
public partial class UMovieSceneNiagaraCacheTrack : UMovieSceneNameableTrack {
// MovieSceneNiagaraCacheTrack
	public bool bIsRecording;
	public TArray<UMovieSceneSection> AnimationSections;
	public bool bCacheRecordingEnabled;
}
