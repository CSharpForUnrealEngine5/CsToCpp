namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ContextualAnimMovieSceneSequence.h")]
public partial class UContextualAnimMovieSceneSequence : UMovieSceneSequence {
	public static UClass StaticClass() {return default;}
	///<summary>@TODO: Remove this and use the actors from the PreviewSceneManager</summary>
	public TMap<FGuid,TWeakObjectPtr<AActor>> BoundActors;
}
