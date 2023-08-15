namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Actor responsible for controlling a specific level sequence in the world.</summary>
[CppInclude("LevelSequenceActor.h")]
public partial class ALevelSequenceActor : AActor {
	public static UClass StaticClass() {return default;}
	///<summary>FOnLevelSequenceLoaded</summary>
	public void FOnLevelSequenceLoaded() {}
	///<summary>PlaybackSettings</summary>
	public FMovieSceneSequencePlaybackSettings PlaybackSettings;
	///<summary>SequencePlayer</summary>
	public ULevelSequencePlayer SequencePlayer;
	///<summary>LevelSequenceAsset</summary>
	public ULevelSequence LevelSequenceAsset;
	///<summary>LevelSequence_DEPRECATED</summary>
	public FSoftObjectPath LevelSequence_DEPRECATED;
	///<summary>CameraSettings</summary>
	public FLevelSequenceCameraSettings CameraSettings;
	///<summary>BurnInOptions</summary>
	public ULevelSequenceBurnInOptions BurnInOptions;
	///<summary>Mapping of actors to override the sequence bindings with</summary>
	public UMovieSceneBindingOverrides BindingOverrides;
	///<summary>bAutoPlay_DEPRECATED</summary>
	public bool bAutoPlay_DEPRECATED;
	///<summary>Enable specification of dynamic instance data to be supplied to the sequence during playback</summary>
	public bool bOverrideInstanceData;
	///<summary>If true, playback of this level sequence on the server will be synchronized across other clients</summary>
	public bool bReplicatePlayback;
	///<summary>Instance data that can be used to dynamically control sequence evaluation at runtime</summary>
	public UObject DefaultInstanceData;
	///<summary>Get the level sequence being played by this actor.</summary>
	public ULevelSequence GetSequence() { return default; }
	///<summary>LoadSequence</summary>
	public ULevelSequence LoadSequence() { return default; }
	///<summary>Set the level sequence being played by this actor.</summary>
	public void SetSequence(ULevelSequence InSequence) {}
	///<summary>Set whether or not to replicate playback for this actor</summary>
	public void SetReplicatePlayback(bool ReplicatePlayback) {}
	///<summary>Access this actor&#39;s sequence player, or None if it is not yet initialized</summary>
	public ULevelSequencePlayer GetSequencePlayer() { return default; }
	///<summary>Hide burnin</summary>
	public void HideBurnin() {}
	///<summary>Show burnin</summary>
	public void ShowBurnin() {}
	///<summary>Overrides the specified binding with the specified actors, optionally still allowing the bindings defined in the Level Sequence asset</summary>
	public void SetBinding(FMovieSceneObjectBindingID Binding,TArray<AActor> Actors,bool bAllowBindingsFromAsset/*=false*/) {}
	///<summary>Assigns an set of actors to all the bindings tagged with the specified name in this sequence. Object Bindings can be tagged within the sequence UI by RMB -&gt; Tags... on the object binding in the tree.</summary>
	public void SetBindingByTag(FName BindingTag,TArray<AActor> Actors,bool bAllowBindingsFromAsset/*=false*/) {}
	///<summary>Adds the specified actor to the overridden bindings for the specified binding ID, optionally still allowing the bindings defined in the Level Sequence asset</summary>
	public void AddBinding(FMovieSceneObjectBindingID Binding,AActor Actor,bool bAllowBindingsFromAsset/*=false*/) {}
	///<summary>Binds an actor to all the bindings tagged with the specified name in this sequence. Does not remove any exising bindings that have been set up through this API. Object Bindings can be tagged within the sequence UI by RMB -&gt; Tags... on the object binding in the tree.</summary>
	public void AddBindingByTag(FName BindingTag,AActor Actor,bool bAllowBindingsFromAsset/*=false*/) {}
	///<summary>Removes the specified actor from the specified binding&#39;s actor array</summary>
	public void RemoveBinding(FMovieSceneObjectBindingID Binding,AActor Actor) {}
	///<summary>Removes the specified actor from the specified binding&#39;s actor array</summary>
	public void RemoveBindingByTag(FName Tag,AActor Actor) {}
	///<summary>Resets the specified binding back to the defaults defined by the Level Sequence asset</summary>
	public void ResetBinding(FMovieSceneObjectBindingID Binding) {}
	///<summary>Resets all overridden bindings back to the defaults defined by the Level Sequence asset</summary>
	public void ResetBindings() {}
	///<summary>Retrieve the first object binding that has been tagged with the specified name</summary>
	public FMovieSceneObjectBindingID FindNamedBinding(FName Tag) { return default; }
	///<summary>Retrieve all the bindings that have been tagged with the specified name</summary>
	public TArray<FMovieSceneObjectBindingID> FindNamedBindings(FName Tag) { return default; }
	///<summary>Burn-in widget</summary>
	public ULevelSequenceBurnIn BurnInInstance;
	///<summary>bShowBurnin</summary>
	public bool bShowBurnin;
}
