#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Compilation/MovieSceneCompiledDataManager.h")]
///<summary>Used for serialization only</summary>
public partial class UMovieSceneCompiledData : UObject {
// MovieSceneCompiledData
	public FMovieSceneEvaluationTemplate EvaluationTemplate;
	public FMovieSceneSequenceHierarchy Hierarchy;
	public FMovieSceneEntityComponentField EntityComponentField;
	public FMovieSceneEvaluationField TrackTemplateField;
	public TArray<FFrameTime> DeterminismFences;
	public FGuid CompiledSignature;
	public FGuid CompilerVersion;
	public FMovieSceneSequenceCompilerMaskStruct AccumulatedMask;
	public FMovieSceneSequenceCompilerMaskStruct AllocatedMask;
	public EMovieSceneSequenceFlags AccumulatedFlags;
}
