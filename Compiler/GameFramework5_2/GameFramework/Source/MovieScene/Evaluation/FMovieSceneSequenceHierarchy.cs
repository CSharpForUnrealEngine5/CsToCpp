#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Structure that stores hierarchical information pertaining to all sequences contained within a root sequence</summary>
[CppInclude("Evaluation/MovieSceneSequenceHierarchy.h")]
public partial struct FMovieSceneSequenceHierarchy {
	public FMovieSceneSequenceHierarchyNode RootNode;
	public FMovieSceneSubSequenceTree Tree;
	public TMap<FMovieSceneSequenceID,FMovieSceneSubSequenceData> SubSequences;
	public TMap<FMovieSceneSequenceID,FMovieSceneSequenceHierarchyNode> Hierarchy;
}
