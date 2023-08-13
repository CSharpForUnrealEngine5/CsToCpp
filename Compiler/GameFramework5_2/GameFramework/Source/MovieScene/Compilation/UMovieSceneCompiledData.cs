namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Used for serialization only</summary>
[CppInclude("Compilation/MovieSceneCompiledDataManager.h")]
public partial class UMovieSceneCompiledData : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>352 Bytes</summary>
	public FMovieSceneEvaluationTemplate EvaluationTemplate;
	///<summary>352 Bytes</summary>
	public FMovieSceneSequenceHierarchy Hierarchy;
	///<summary>272 Bytes</summary>
	public FMovieSceneEntityComponentField EntityComponentField;
	///<summary>64 Bytes</summary>
	public FMovieSceneEvaluationField TrackTemplateField;
	///<summary>16 Bytes</summary>
	public TArray<FFrameTime> DeterminismFences;
	///<summary>16 bytes</summary>
	public FGuid CompiledSignature;
	///<summary>16 Bytes</summary>
	public FGuid CompilerVersion;
	///<summary>1 Byte</summary>
	public FMovieSceneSequenceCompilerMaskStruct AccumulatedMask;
	///<summary>1 Byte</summary>
	public FMovieSceneSequenceCompilerMaskStruct AllocatedMask;
	///<summary>1 Byte</summary>
	public EMovieSceneSequenceFlags AccumulatedFlags;
}
