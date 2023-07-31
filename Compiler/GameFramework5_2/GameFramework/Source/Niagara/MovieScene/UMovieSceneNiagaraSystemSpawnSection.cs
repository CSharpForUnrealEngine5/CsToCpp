#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MovieScene/MovieSceneNiagaraSystemSpawnSection.h")]
public partial class UMovieSceneNiagaraSystemSpawnSection : UMovieSceneSection {
	///<summary>Specifies what should happen to the niagara system from before the section evaluates up until the first frame of the section.</summary>
	public ENiagaraSystemSpawnSectionStartBehavior SectionStartBehavior;
	///<summary>Specifies what should happen to the niagara system when section is evaluating from the 2nd frame until the last frame.</summary>
	public ENiagaraSystemSpawnSectionEvaluateBehavior SectionEvaluateBehavior;
	///<summary>Specifies what should happen to the niagara system when section evaluation finishes.</summary>
	public ENiagaraSystemSpawnSectionEndBehavior SectionEndBehavior;
	///<summary>Specifies how sequencer should update the age of the controlled niagara system.</summary>
	public ENiagaraAgeUpdateMode AgeUpdateMode;
	///<summary>bAllowScalability</summary>
	public bool bAllowScalability;
}
