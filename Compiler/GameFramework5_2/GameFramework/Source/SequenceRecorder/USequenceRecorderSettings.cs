#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("SequenceRecorderSettings.h")]
public partial class USequenceRecorderSettings : UObject {
// SequenceRecorderSettings
	public bool bCreateLevelSequence;
	public bool bImmersiveMode;
	public float SequenceLength;
	public float RecordingDelay;
	public bool bAllowLooping;
	public float GlobalTimeDilation;
	public bool bIgnoreTimeDilation;
	public string AnimationSubDirectory;
	public EAudioRecordingMode RecordAudio;
	public float AudioGain;
	public bool bSplitAudioChannelsIntoSeparateTracks;
	public bool bReplaceRecordedAudio;
	public string AudioTrackName;
	public string AudioSubDirectory;
	public bool bRecordNearbySpawnedActors;
	public float NearbyActorRecordingProximity;
	public bool bRecordWorldSettingsActor;
	public bool bReduceKeys;
	public bool bAutoSaveAsset;
	public FSequenceRecorderActorFilter ActorFilter;
	public TArray<TLazyObjectPtr<ALevelSequenceActor>> LevelSequenceActorsToTrigger;
	public FAnimationRecordingSettings DefaultAnimationSettings;
	public bool bRecordSequencerSpawnedActors;
	public TArray<FPropertiesToRecordForClass> ClassesAndPropertiesToRecord;
	public TArray<FPropertiesToRecordForActorClass> ActorsAndPropertiesToRecord;
	public TArray<FSettingsForActorClass> PerActorSettings;
}
