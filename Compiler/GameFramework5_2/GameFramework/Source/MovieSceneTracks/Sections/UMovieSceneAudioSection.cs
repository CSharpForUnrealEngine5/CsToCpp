#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Sections/MovieSceneAudioSection.h")]
///<summary>Audio section, for use in the audio track, or by attached audio objects</summary>
public partial class UMovieSceneAudioSection : UMovieSceneSection {
// MovieSceneAudioSection
	public  void SetSound(USoundBase InSound) {}
	public  USoundBase GetSound() { return default; }
	public  void SetStartOffset(FFrameNumber InStartOffset) {}
	public  FFrameNumber GetStartOffset() { return default; }
	public USoundBase Sound;
	public FFrameNumber StartFrameOffset;
	public float StartOffset_DEPRECATED;
	public float AudioStartTime_DEPRECATED;
	public float AudioDilationFactor_DEPRECATED;
	public float AudioVolume_DEPRECATED;
	public FMovieSceneFloatChannel SoundVolume;
	public FMovieSceneFloatChannel PitchMultiplier;
	public TMap<string,FMovieSceneFloatChannel> Inputs_Float;
	public TMap<string,FMovieSceneStringChannel> Inputs_String;
	public TMap<string,FMovieSceneBoolChannel> Inputs_Bool;
	public TMap<string,FMovieSceneIntegerChannel> Inputs_Int;
	public TMap<string,FMovieSceneAudioTriggerChannel> Inputs_Trigger;
	public FMovieSceneActorReferenceData AttachActorData;
	public bool bLooping;
	public bool bSuppressSubtitles;
	public bool bOverrideAttenuation;
	public USoundAttenuation AttenuationSettings;
	public FOnQueueSubtitles OnQueueSubtitles;
	public FOnAudioFinished OnAudioFinished;
	public FOnAudioPlaybackPercent OnAudioPlaybackPercent;
}
