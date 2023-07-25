#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MovieSceneObjectBindingID.h")]
///<summary>Persistent identifier to a specific object binding within a sequence hierarchy.</summary>
public partial struct FMovieSceneObjectBindingID {
// MovieSceneObjectBindingID
	public FGuid Guid;
	public int SequenceID;
	public int ResolveParentIndex;
	public EMovieSceneObjectBindingSpace Space_DEPRECATED;
}
