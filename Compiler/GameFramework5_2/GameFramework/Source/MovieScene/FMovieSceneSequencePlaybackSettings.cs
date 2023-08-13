namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Settings for the level sequence player actor.</summary>
[CppInclude("MovieSceneSequencePlaybackSettings.h")]
public partial struct FMovieSceneSequencePlaybackSettings {
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
