#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Sub sequence data that is stored within an evaluation template as a backreference to the originating sequence, and section</summary>
[CppInclude("Evaluation/MovieSceneSequenceHierarchy.h")]
public partial struct FMovieSceneSubSequenceData {
	public FSoftObjectPath Sequence;
	public FMovieSceneSequenceTransform OuterToInnerTransform;
	public FMovieSceneSequenceTransform RootToSequenceTransform;
	public FFrameRate TickResolution;
	public FMovieSceneSequenceID DeterministicSequenceID;
	public FMovieSceneFrameRange ParentPlayRange;
	public FFrameNumber ParentStartFrameOffset;
	public FFrameNumber ParentEndFrameOffset;
	public FFrameNumber ParentFirstLoopStartFrameOffset;
	public bool bCanLoop;
	public FMovieSceneFrameRange PlayRange;
	public FMovieSceneFrameRange FullPlayRange;
	public FMovieSceneFrameRange UnwarpedPlayRange;
	public FMovieSceneFrameRange PreRollRange;
	public FMovieSceneFrameRange PostRollRange;
	public short HierarchicalBias;
	public FMovieSceneSequenceInstanceDataPtr InstanceData;
	public string SectionPath;
	public FGuid SubSectionSignature;
}
