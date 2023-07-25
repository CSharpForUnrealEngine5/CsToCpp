#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("CameraAnimationSequencePlayer.h")]
///<summary>A lightweight sequence player for playing camera animation sequences.</summary>
public partial class UCameraAnimationSequencePlayer : UObject {
// CameraAnimationSequencePlayer
	public UObject BoundObjectOverride;
	public UMovieSceneSequence Sequence;
	public FMovieSceneRootEvaluationTemplateInstance RootTemplateInstance;
}
