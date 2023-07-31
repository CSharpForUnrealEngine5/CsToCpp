#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A lightweight sequence player for playing camera animation sequences.</summary>
[CppInclude("CameraAnimationSequencePlayer.h")]
public partial class UCameraAnimationSequencePlayer : UObject {
	///<summary>Bound object overrides</summary>
	public UObject BoundObjectOverride;
	///<summary>The sequence to play back</summary>
	public UMovieSceneSequence Sequence;
	///<summary>The evaluation template instance</summary>
	public FMovieSceneRootEvaluationTemplateInstance RootTemplateInstance;
}
