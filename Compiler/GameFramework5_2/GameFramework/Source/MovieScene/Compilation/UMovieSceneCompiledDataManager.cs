#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Compilation/MovieSceneCompiledDataManager.h")]
public partial class UMovieSceneCompiledDataManager : UObject {
// MovieSceneCompiledDataManager
	public TMap<int,FMovieSceneSequenceHierarchy> Hierarchies;
	public TMap<int,FMovieSceneEvaluationTemplate> TrackTemplates;
	public TMap<int,FMovieSceneEvaluationField> TrackTemplateFields;
	public TMap<int,FMovieSceneEntityComponentField> EntityComponentFields;
}
