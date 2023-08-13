namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A lightweight sequence player for playing camera animation sequences.</summary>
[CppInclude("CameraAnimationSequencePlayer.h")]
public partial class UCameraAnimationSequencePlayer : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Bound object overrides</summary>
	public UObject BoundObjectOverride;
	///<summary>The sequence to play back</summary>
	public UMovieSceneSequence Sequence;
	///<summary>The evaluation template instance</summary>
	public FMovieSceneRootEvaluationTemplateInstance RootTemplateInstance;
}
