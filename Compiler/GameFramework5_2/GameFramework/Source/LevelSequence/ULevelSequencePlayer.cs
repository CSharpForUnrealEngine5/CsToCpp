#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("LevelSequencePlayer.h")]
///<summary>ULevelSequencePlayer is used to actually "play" an level sequence asset at runtime.</summary>
public partial class ULevelSequencePlayer : UMovieSceneSequencePlayer {
// LevelSequencePlayer
	public static ULevelSequencePlayer CreateLevelSequencePlayer(UObject WorldContextObject,ULevelSequence LevelSequence,FMovieSceneSequencePlaybackSettings Settings,ALevelSequenceActor OutActor) { return default; }
	public FOnLevelSequencePlayerCameraCutEvent OnCameraCut;
	public  UCameraComponent GetActiveCameraComponent() { return default; }
}
