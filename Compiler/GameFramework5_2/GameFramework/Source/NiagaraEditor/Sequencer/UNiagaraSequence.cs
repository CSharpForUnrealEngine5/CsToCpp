namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Movie scene sequence used by Niagara.</summary>
[CppInclude("Sequencer/NiagaraSequence/NiagaraSequence.h")]
public partial class UNiagaraSequence : UMovieSceneSequence {
	public static UClass StaticClass() {return default;}
	///<summary>Pointer to the movie scene that controls this sequence.</summary>
	public UMovieScene MovieScene;
}
