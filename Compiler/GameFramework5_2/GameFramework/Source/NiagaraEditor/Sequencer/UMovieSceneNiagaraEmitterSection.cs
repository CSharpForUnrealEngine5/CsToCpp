#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Niagara editor movie scene section; represents one emitter in the timeline</summary>
[CppInclude("Sequencer/NiagaraSequence/Sections/MovieSceneNiagaraEmitterSection.h")]
public partial class UMovieSceneNiagaraEmitterSection : UMovieSceneNiagaraEmitterSectionBase {
	public static UClass StaticClass() {return default;}
	///<summary>NumLoops</summary>
	public int NumLoops;
	///<summary>bStartTimeIncludedInFirstLoopOnly</summary>
	public bool bStartTimeIncludedInFirstLoopOnly;
}
