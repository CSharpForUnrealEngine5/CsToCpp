#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("LevelSequencePlayer.h")]
///<summary>ULevelSequencePlayer is used to actually "play" an level sequence asset at runtime.</summary>
public partial class ULevelSequencePlayer : UMovieSceneSequencePlayer {
// LevelSequencePlayer
	public UObject CreateLevelSequencePlayer(UObject WorldContextObject,UObject LevelSequence,FMovieSceneSequencePlaybackSettings Settings,UObject OutActor) { return default; }
	public FOnLevelSequencePlayerCameraCutEvent OnCameraCut;
	public UObject GetActiveCameraComponent() { return default; }
}
