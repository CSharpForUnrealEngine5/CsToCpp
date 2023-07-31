#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ContextualAnimMovieSceneSequence.h")]
public partial class UContextualAnimMovieSceneSequence : UMovieSceneSequence {
	///<summary>@TODO: Remove this and use the actors from the PreviewSceneManager</summary>
	public TMap<FGuid,TWeakObjectPtr<AActor>> BoundActors;
}
