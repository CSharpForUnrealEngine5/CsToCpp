#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Actor responsible for controlling a specific template sequence in the world.</summary>
[CppInclude("TemplateSequenceActor.h")]
public partial class ATemplateSequenceActor : AActor {
	public static UClass StaticClass() {return default;}
	///<summary>PlaybackSettings</summary>
	public FMovieSceneSequencePlaybackSettings PlaybackSettings;
	///<summary>SequencePlayer</summary>
	public UTemplateSequencePlayer SequencePlayer;
	///<summary>TemplateSequence</summary>
	public FSoftObjectPath TemplateSequence;
	///<summary>The override for the template sequence&#39;s root object binding. See SetBinding.</summary>
	public FTemplateSequenceBindingOverrideData BindingOverride;
	///<summary>Get the template sequence being played by this actor.</summary>
	public  UTemplateSequence GetSequence() { return default; }
	///<summary>Get the template sequence being played by this actor.</summary>
	public  UTemplateSequence LoadSequence() { return default; }
	///<summary>Set the template sequence being played by this actor.</summary>
	public  void SetSequence(UTemplateSequence InSequence) {}
	///<summary>Get the actor&#39;s sequence player, or nullptr if it not yet initialized.</summary>
	public  UTemplateSequencePlayer GetSequencePlayer() { return default; }
	///<summary>Set the actor to play the template sequence onto, by setting up an override for the template</summary>
	public  void SetBinding(AActor Actor,bool bOverridesDefault/*=true*/) {}
}
