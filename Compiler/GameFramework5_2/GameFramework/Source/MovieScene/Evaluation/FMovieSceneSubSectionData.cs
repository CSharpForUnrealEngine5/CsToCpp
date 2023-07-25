#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Evaluation/MovieSceneEvaluationTemplate.h")]
///<summary>Data that represents a single sub-section</summary>
public partial struct FMovieSceneSubSectionData {
// MovieSceneSubSectionData
	public TWeakObjectPtr<UMovieSceneSubSection> Section;
	public FGuid ObjectBindingId;
	public ESectionEvaluationFlags Flags;
}
