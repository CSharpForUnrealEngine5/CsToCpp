namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>* Movie scene animation that can be instanced multiple times inside a level sequence.</summary>
[CppInclude("TemplateSequence.h")]
public partial class UTemplateSequence : UMovieSceneSequence {
	public static UClass StaticClass() {return default;}
	///<summary>MovieScene</summary>
	public UMovieScene MovieScene;
	///<summary>BoundActorClass</summary>
	public TSoftObjectPtr<UClass> BoundActorClass;
	///<summary>BoundActorComponents</summary>
	public TMap<FGuid,string> BoundActorComponents;
}
