#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Movie Scene Binding Proxy represents the binding ID (an FGuid) and the corresponding sequence that it relates to.</summary>
[CppInclude("MovieSceneBindingProxy.h")]
public partial struct FMovieSceneBindingProxy {
	public FGuid BindingID;
	public UMovieSceneSequence Sequence;
}
