#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A base class for tracks that animate niagara parameters.</summary>
[CppInclude("MovieScene/Parameters/MovieSceneNiagaraParameterTrack.h")]
public partial class UMovieSceneNiagaraParameterTrack : UMovieSceneNiagaraTrack {
	public static UClass StaticClass() {return default;}
	///<summary>The parameter for the parameter this track animates.</summary>
	public FNiagaraVariable Parameter;
}
