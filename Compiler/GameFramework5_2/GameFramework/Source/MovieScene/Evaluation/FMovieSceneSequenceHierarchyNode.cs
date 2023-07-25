#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Evaluation/MovieSceneSequenceHierarchy.h")]
///<summary>Simple structure specifying parent and child sequence IDs for any given sequences</summary>
public partial struct FMovieSceneSequenceHierarchyNode {
// MovieSceneSequenceHierarchyNode
	public FMovieSceneSequenceID ParentID;
	public TArray<FMovieSceneSequenceID> Children;
}
