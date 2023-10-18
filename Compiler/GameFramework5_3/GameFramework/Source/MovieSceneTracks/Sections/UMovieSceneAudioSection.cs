namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Audio section, for use in the audio track, or by attached audio objects</summary>
[CppInclude("Sections/MovieSceneAudioSection.h")]
public partial class UMovieSceneAudioSection : UMovieSceneSection {
	public static UClass StaticClass() {return default;}
	///<summary>Sets this section&#39;s sound</summary>
	public void SetSound(USoundBase InSound) {}
	///<summary>Gets the sound for this section</summary>
	public USoundBase GetSound() { return default; }
	///<summary>Set the offset into the beginning of the audio clip</summary>
	public void SetStartOffset(FFrameNumber InStartOffset) {}
	///<summary>Get the offset into the beginning of the audio clip</summary>
	public FFrameNumber GetStartOffset() { return default; }
	///<summary>@return Whether to allow looping if the section length is greater than the sound duration</summary>
	public bool GetLooping() { return default; }
	///<summary>Set whether the sound should be looped</summary>
	public void SetLooping(bool bInLooping) {}
	///<summary>@return Whether subtitles should be suppressed</summary>
	public bool GetSuppressSubtitles() { return default; }
	///<summary>Set whether subtitles should be suppressed</summary>
	public void SetSuppressSubtitles(bool bInSuppressSubtitles) {}
	///<summary>@return Whether override settings on this section should be used</summary>
	public bool GetOverrideAttenuation() { return default; }
	///<summary>Set whether the attentuation should be overriden</summary>
	public void SetOverrideAttenuation(bool bInOverrideAttenuation) {}
	///<summary>@return The attenuation settings</summary>
	public USoundAttenuation GetAttenuationSettings() { return default; }
	///<summary>Set the attenuation settings for this audio section</summary>
	public void SetAttenuationSettings(USoundAttenuation InAttenuationSettings) {}
	///<summary>The sound cue or wave that this section plays</summary>
	public USoundBase Sound;
	///<summary>The offset into the beginning of the audio clip</summary>
	public FFrameNumber StartFrameOffset;
	///<summary>The offset into the beginning of the audio clip</summary>
	public float StartOffset_DEPRECATED;
	///<summary>The absolute time that the sound starts playing at</summary>
	public float AudioStartTime_DEPRECATED;
	///<summary>The amount which this audio is time dilated by</summary>
	public float AudioDilationFactor_DEPRECATED;
	///<summary>The volume the sound will be played with.</summary>
	public float AudioVolume_DEPRECATED;
	///<summary>The volume the sound will be played with.</summary>
	public FMovieSceneFloatChannel SoundVolume;
	///<summary>The pitch multiplier the sound will be played with.</summary>
	public FMovieSceneFloatChannel PitchMultiplier;
	///<summary>Generic inputs for the sound</summary>
	public TMap<FName,FMovieSceneFloatChannel> Inputs_Float;
	///<summary>Inputs_String</summary>
	public TMap<FName,FMovieSceneStringChannel> Inputs_String;
	///<summary>Inputs_Bool</summary>
	public TMap<FName,FMovieSceneBoolChannel> Inputs_Bool;
	///<summary>Inputs_Int</summary>
	public TMap<FName,FMovieSceneIntegerChannel> Inputs_Int;
	///<summary>Inputs_Trigger</summary>
	public TMap<FName,FMovieSceneAudioTriggerChannel> Inputs_Trigger;
	///<summary>AttachActorData</summary>
	public FMovieSceneActorReferenceData AttachActorData;
	///<summary>Allow looping if the section length is greater than the sound duration</summary>
	public bool bLooping;
	///<summary>bSuppressSubtitles</summary>
	public bool bSuppressSubtitles;
	///<summary>Should the attenuation settings on this section be used.</summary>
	public bool bOverrideAttenuation;
	///<summary>The attenuation settings to use.</summary>
	public USoundAttenuation AttenuationSettings;
	///<summary>Called when subtitles are sent to the SubtitleManager.  Set this delegate if you want to hijack the subtitles for other purposes</summary>
	public FOnQueueSubtitles OnQueueSubtitles;
	///<summary>called when we finish playing audio, either because it played to completion or because a Stop() call turned it off early</summary>
	public FOnAudioFinished OnAudioFinished;
	///<summary>OnAudioPlaybackPercent</summary>
	public FOnAudioPlaybackPercent OnAudioPlaybackPercent;
}
