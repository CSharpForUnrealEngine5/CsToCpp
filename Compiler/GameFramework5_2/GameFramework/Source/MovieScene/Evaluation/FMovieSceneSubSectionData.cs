#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Data that represents a single sub-section</summary>
[CppInclude("Evaluation/MovieSceneEvaluationTemplate.h")]
public partial struct FMovieSceneSubSectionData {
	public TWeakObjectPtr<UMovieSceneSubSection> Section;
	public FGuid ObjectBindingId;
	public ESectionEvaluationFlags Flags;
}
