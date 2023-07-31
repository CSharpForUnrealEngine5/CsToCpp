#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>ULevelSequencePlayer is used to actually &quot;play&quot; an level sequence asset at runtime.</summary>
[CppInclude("LevelSequencePlayer.h")]
public partial class ULevelSequencePlayer : UMovieSceneSequencePlayer {
	///<summary>Create a new level sequence player.</summary>
	public static ULevelSequencePlayer CreateLevelSequencePlayer(UObject WorldContextObject,ULevelSequence LevelSequence,FMovieSceneSequencePlaybackSettings Settings,ALevelSequenceActor OutActor) { return default; }
	///<summary>Event triggered when there is a camera cut</summary>
	public FOnLevelSequencePlayerCameraCutEvent OnCameraCut;
	///<summary>Get the active camera cut camera</summary>
	public  UCameraComponent GetActiveCameraComponent() { return default; }
}
