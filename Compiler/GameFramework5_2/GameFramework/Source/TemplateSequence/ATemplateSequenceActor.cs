#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("TemplateSequenceActor.h")]
///<summary>Actor responsible for controlling a specific template sequence in the world.</summary>
public partial class ATemplateSequenceActor : AActor {
// TemplateSequenceActor
	public FMovieSceneSequencePlaybackSettings PlaybackSettings;
	public UTemplateSequencePlayer SequencePlayer;
	public FSoftObjectPath TemplateSequence;
	public FTemplateSequenceBindingOverrideData BindingOverride;
	public  UTemplateSequence GetSequence() { return default; }
	public  UTemplateSequence LoadSequence() { return default; }
	public  void SetSequence(UTemplateSequence InSequence) {}
	public  UTemplateSequencePlayer GetSequencePlayer() { return default; }
	public  void SetBinding(AActor Actor,bool bOverridesDefault/*=true*/) {}
}
