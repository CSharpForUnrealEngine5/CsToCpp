namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>ULevelSequencePlayer is used to actually &quot;play&quot; an level sequence asset at runtime.</summary>
[CppInclude("LevelSequencePlayer.h")]
public partial class ULevelSequencePlayer : UMovieSceneSequencePlayer {
	public static UClass StaticClass() {return default;}
	///<summary>Create a new level sequence player.</summary>
	public static ULevelSequencePlayer CreateLevelSequencePlayer(UObject WorldContextObject,ULevelSequence LevelSequence,FMovieSceneSequencePlaybackSettings Settings,ALevelSequenceActor OutActor) { return default; }
	///<summary>Event triggered when there is a camera cut</summary>
	public FOnLevelSequencePlayerCameraCutEvent OnCameraCut;
	///<summary>Get the active camera cut camera</summary>
	public UCameraComponent GetActiveCameraComponent() { return default; }
}
