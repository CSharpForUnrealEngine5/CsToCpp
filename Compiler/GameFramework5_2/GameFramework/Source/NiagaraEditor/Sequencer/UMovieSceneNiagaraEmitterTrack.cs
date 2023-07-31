#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A track representing an emitter in the niagara effect editor timeline.</summary>
[CppInclude("Sequencer/NiagaraSequence/MovieSceneNiagaraEmitterTrack.h")]
public partial class UMovieSceneNiagaraEmitterTrack : UMovieSceneNameableTrack {
	///<summary>Sections</summary>
	public TArray<UMovieSceneSection> Sections;
	///<summary>bSectionsWereModified</summary>
	public bool bSectionsWereModified;
	///<summary>Used for detecting copy/paste</summary>
	public FGuid EmitterHandleId;
	///<summary>Used for detecting copy/paste</summary>
	public string SystemPath;
}
