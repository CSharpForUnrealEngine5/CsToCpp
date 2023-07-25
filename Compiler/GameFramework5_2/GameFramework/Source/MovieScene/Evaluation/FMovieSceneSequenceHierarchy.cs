#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Evaluation/MovieSceneSequenceHierarchy.h")]
///<summary>Structure that stores hierarchical information pertaining to all sequences contained within a root sequence</summary>
public partial struct FMovieSceneSequenceHierarchy {
// MovieSceneSequenceHierarchy
	public FMovieSceneSequenceHierarchyNode RootNode;
	public FMovieSceneSubSequenceTree Tree;
	public TMap<FMovieSceneSequenceID,FMovieSceneSubSequenceData> SubSequences;
	public TMap<FMovieSceneSequenceID,FMovieSceneSequenceHierarchyNode> Hierarchy;
}
