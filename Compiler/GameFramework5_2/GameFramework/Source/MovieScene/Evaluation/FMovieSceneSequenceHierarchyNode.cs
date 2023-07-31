#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Simple structure specifying parent and child sequence IDs for any given sequences</summary>
[CppInclude("Evaluation/MovieSceneSequenceHierarchy.h")]
public partial struct FMovieSceneSequenceHierarchyNode {
	public FMovieSceneSequenceID ParentID;
	public TArray<FMovieSceneSequenceID> Children;
}
