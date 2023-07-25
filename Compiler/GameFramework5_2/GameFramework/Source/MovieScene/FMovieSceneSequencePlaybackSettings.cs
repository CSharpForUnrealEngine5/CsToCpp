#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MovieSceneSequencePlaybackSettings.h")]
///<summary>Settings for the level sequence player actor.</summary>
public partial struct FMovieSceneSequencePlaybackSettings {
// MovieSceneSequencePlaybackSettings
	public bool bAutoPlay;
	public FMovieSceneSequenceLoopCount LoopCount;
	public FMovieSceneSequenceTickInterval TickInterval;
	public float PlayRate;
	public float StartTime;
	public bool bRandomStartTime;
	public bool bRestoreState;
	public bool bDisableMovementInput;
	public bool bDisableLookAtInput;
	public bool bHidePlayer;
	public bool bHideHud;
	public bool bDisableCameraCuts;
	public bool bPauseAtEnd;
	public bool bInheritTickIntervalFromOwner;
	public bool bDynamicWeighting;
}
