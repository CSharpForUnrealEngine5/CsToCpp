namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Optional parameter struct for dynamic binding resolver functions.</summary>
[CppInclude("MovieSceneDynamicBinding.h")]
public partial struct FMovieSceneDynamicBindingResolveParams {
	public UMovieSceneSequence Sequence;
	public FGuid ObjectBindingID;
	public UMovieSceneSequence RootSequence;
}
