#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("LevelSequenceActor.h")]
///<summary>Actor responsible for controlling a specific level sequence in the world.</summary>
public partial class ALevelSequenceActor : AActor {
// LevelSequenceActor
	public  void FOnLevelSequenceLoaded() {}
	public FMovieSceneSequencePlaybackSettings PlaybackSettings;
	public ULevelSequencePlayer SequencePlayer;
	public ULevelSequence LevelSequenceAsset;
	public FSoftObjectPath LevelSequence_DEPRECATED;
	public FLevelSequenceCameraSettings CameraSettings;
	public ULevelSequenceBurnInOptions BurnInOptions;
	public UMovieSceneBindingOverrides BindingOverrides;
	public bool bAutoPlay_DEPRECATED;
	public bool bOverrideInstanceData;
	public bool bReplicatePlayback;
	public UObject DefaultInstanceData;
	public  ULevelSequence GetSequence() { return default; }
	public  ULevelSequence LoadSequence() { return default; }
	public  void SetSequence(ULevelSequence InSequence) {}
	public  void SetReplicatePlayback(bool ReplicatePlayback) {}
	public  ULevelSequencePlayer GetSequencePlayer() { return default; }
	public  void HideBurnin() {}
	public  void ShowBurnin() {}
	public  void SetBinding(FMovieSceneObjectBindingID Binding,TArray<AActor> Actors,bool bAllowBindingsFromAsset/*=false*/) {}
	public  void SetBindingByTag(string BindingTag,TArray<AActor> Actors,bool bAllowBindingsFromAsset/*=false*/) {}
	public  void AddBinding(FMovieSceneObjectBindingID Binding,AActor Actor,bool bAllowBindingsFromAsset/*=false*/) {}
	public  void AddBindingByTag(string BindingTag,AActor Actor,bool bAllowBindingsFromAsset/*=false*/) {}
	public  void RemoveBinding(FMovieSceneObjectBindingID Binding,AActor Actor) {}
	public  void RemoveBindingByTag(string Tag,AActor Actor) {}
	public  void ResetBinding(FMovieSceneObjectBindingID Binding) {}
	public  void ResetBindings() {}
	public  FMovieSceneObjectBindingID FindNamedBinding(string Tag) { return default; }
	public  TArray<FMovieSceneObjectBindingID> FindNamedBindings(string Tag) { return default; }
	public ULevelSequenceBurnIn BurnInInstance;
	public bool bShowBurnin;
}
