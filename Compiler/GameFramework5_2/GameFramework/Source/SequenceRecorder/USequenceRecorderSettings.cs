#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("SequenceRecorderSettings.h")]
public partial class USequenceRecorderSettings : UObject {
	///<summary>Whether to create a level sequence when recording. Actors and animations will be inserted into this sequence</summary>
	public bool bCreateLevelSequence;
	///<summary>Whether to maximize the viewport when recording</summary>
	public bool bImmersiveMode;
	///<summary>The length of the recorded sequence</summary>
	public float SequenceLength;
	///<summary>Delay that we will use before starting recording</summary>
	public float RecordingDelay;
	///<summary>Allow the recording to be looped. Subsequence recorded assets will be saved to unique filenames.</summary>
	public bool bAllowLooping;
	///<summary>Global Time dilation to set the world to when recording starts. Useful for playing back a scene in slow motion.</summary>
	public float GlobalTimeDilation;
	///<summary>Should Sequence Recorder ignore global time dilation? If true recorded animations will only be as long as they would have been without global time dilation.</summary>
	public bool bIgnoreTimeDilation;
	///<summary>The name of the subdirectory animations will be placed in. Leave this empty to place into the same directory as the sequence base path</summary>
	public string AnimationSubDirectory;
	///<summary>Whether to record audio alongside animation or not</summary>
	public EAudioRecordingMode RecordAudio;
	///<summary>Gain in decibels to apply to recorded audio</summary>
	public float AudioGain;
	///<summary>Whether or not to split mic channels into separate audio tracks. If not true, a max of 2 input channels is supported.</summary>
	public bool bSplitAudioChannelsIntoSeparateTracks;
	///<summary>Replace existing recorded audio with any newly recorded audio</summary>
	public bool bReplaceRecordedAudio;
	///<summary>Name of the recorded audio track name</summary>
	public string AudioTrackName;
	///<summary>The name of the subdirectory audio will be placed in. Leave this empty to place into the same directory as the sequence base path</summary>
	public string AudioSubDirectory;
	///<summary>Whether to record nearby spawned actors. If an actor matches a class in the ActorFilter, this state will be bypassed.</summary>
	public bool bRecordNearbySpawnedActors;
	///<summary>Proximity to currently recorded actors to record newly spawned actors.</summary>
	public float NearbyActorRecordingProximity;
	///<summary>Whether to record the world settings actor in the sequence (some games use this to attach world SFX)</summary>
	public bool bRecordWorldSettingsActor;
	///<summary>Whether to remove keyframes within a tolerance from the recorded tracks</summary>
	public bool bReduceKeys;
	///<summary>Whether to auto-save asset when recording is completed. Defaults to false</summary>
	public bool bAutoSaveAsset;
	///<summary>Filter to check spawned actors against to see if they should be recorded</summary>
	public FSequenceRecorderActorFilter ActorFilter;
	///<summary>Sequence actors to trigger playback on when recording starts (e.g. for recording synchronized sequences)</summary>
	public TArray<TLazyObjectPtr<ALevelSequenceActor>> LevelSequenceActorsToTrigger;
	///<summary>Default animation settings which are used to initialize all new actor recording&#39;s animation settings</summary>
	public FAnimationRecordingSettings DefaultAnimationSettings;
	///<summary>Whether to record actors that are spawned by sequencer itself (this is usually disabled as results can be unexpected)</summary>
	public bool bRecordSequencerSpawnedActors;
	///<summary>The properties to record for specified classes. Component classes specified here will be recorded. If an actor does not contain one of these classes it will be ignored.</summary>
	public TArray<FPropertiesToRecordForClass> ClassesAndPropertiesToRecord;
	///<summary>The properties to record for specified actors. Actor classes specified here will be recorded. If an actor does not contain one of these properties it will be ignored.</summary>
	public TArray<FPropertiesToRecordForActorClass> ActorsAndPropertiesToRecord;
	///<summary>Settings applied to actors of a specified class</summary>
	public TArray<FSettingsForActorClass> PerActorSettings;
}
