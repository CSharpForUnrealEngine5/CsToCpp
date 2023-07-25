#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("TemplateSequence.h")]
///<summary>* Movie scene animation that can be instanced multiple times inside a level sequence.</summary>
public partial class UTemplateSequence : UMovieSceneSequence {
// TemplateSequence
	public UMovieScene MovieScene;
	public TSoftObjectPtr<UClass> BoundActorClass;
	public TMap<FGuid,string> BoundActorComponents;
}
