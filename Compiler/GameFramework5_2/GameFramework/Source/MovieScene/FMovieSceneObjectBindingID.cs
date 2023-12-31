namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Persistent identifier to a specific object binding within a sequence hierarchy.</summary>
[CppInclude("MovieSceneObjectBindingID.h")]
public partial struct FMovieSceneObjectBindingID {
	public FGuid Guid;
	public int SequenceID;
	public int ResolveParentIndex;
	public EMovieSceneObjectBindingSpace Space_DEPRECATED;
}
