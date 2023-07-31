#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>* Movie scene animation that can be instanced multiple times inside a level sequence.</summary>
[CppInclude("TemplateSequence.h")]
public partial class UTemplateSequence : UMovieSceneSequence {
	///<summary>MovieScene</summary>
	public UMovieScene MovieScene;
	///<summary>BoundActorClass</summary>
	public TSoftObjectPtr<UClass> BoundActorClass;
	///<summary>BoundActorComponents</summary>
	public TMap<FGuid,string> BoundActorComponents;
}
