#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MovieSceneBindingProxy.h")]
///<summary>Movie Scene Binding Proxy represents the binding ID (an FGuid) and the corresponding sequence that it relates to.</summary>
public partial struct FMovieSceneBindingProxy {
// MovieSceneBindingProxy
	public FGuid BindingID;
	public UMovieSceneSequence Sequence;
}
