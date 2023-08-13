namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Data that represents a single sub-section</summary>
[CppInclude("Evaluation/MovieSceneEvaluationTemplate.h")]
public partial struct FMovieSceneSubSectionData {
	public TWeakObjectPtr<UMovieSceneSubSection> Section;
	public FGuid ObjectBindingId;
	public ESectionEvaluationFlags Flags;
}
