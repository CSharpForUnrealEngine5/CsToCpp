#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Compilation/MovieSceneCompiledDataManager.h")]
public partial class UMovieSceneCompiledDataManager : UObject {
	///<summary>Hierarchies</summary>
	public TMap<int,FMovieSceneSequenceHierarchy> Hierarchies;
	///<summary>TrackTemplates</summary>
	public TMap<int,FMovieSceneEvaluationTemplate> TrackTemplates;
	///<summary>TrackTemplateFields</summary>
	public TMap<int,FMovieSceneEvaluationField> TrackTemplateFields;
	///<summary>EntityComponentFields</summary>
	public TMap<int,FMovieSceneEntityComponentField> EntityComponentFields;
}
