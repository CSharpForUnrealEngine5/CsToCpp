#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Sequencer/NiagaraSequence/MovieSceneNiagaraEmitterTrack.h")]
///<summary>A track representing an emitter in the niagara effect editor timeline.</summary>
public partial class UMovieSceneNiagaraEmitterTrack : UMovieSceneNameableTrack {
// MovieSceneNiagaraEmitterTrack
	public TArray<UMovieSceneSection> Sections;
	public bool bSectionsWereModified;
	public FGuid EmitterHandleId;
	public string SystemPath;
}
