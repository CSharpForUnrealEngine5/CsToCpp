#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("LevelSequence/LevelSequencePlaybackController.h")]
public partial class ULevelSequencePlaybackController : UObject {
	///<summary>Returns the names of each level sequence actor that is present in the level.</summary>
	public  void GetLevelSequences(TArray<FLevelSequenceData> OutLevelSequenceNames) {}
	///<summary>@return the name of the currently selected sequence; returns empty string if no selected sequence</summary>
	public  string GetActiveLevelSequenceName() { return default; }
	///<summary>@return the currently selected LevelSequence</summary>
	public  ULevelSequence GetActiveLevelSequence() { return default; }
	///<summary>@return the FrameRate of the currently loaded sequence FrameRate</summary>
	public  FFrameRate GetCurrentSequenceFrameRate() { return default; }
	///<summary>@return true if the active Sequencer is locked to camera cut</summary>
	public  bool IsSequencerLockedToCameraCut() { return default; }
	///<summary>Sets the current Sequencer perspective to be locked to camera cut</summary>
	public  void SetSequencerLockedToCameraCut(bool bLockView) {}
	///<summary>@return The FrameNumber of the sequence&#39;s start.</summary>
	public  FFrameNumber GetCurrentSequencePlaybackStart() { return default; }
	///<summary>@return The FrameNumber of the sequence&#39;s end.</summary>
	public  FFrameNumber GetCurrentSequencePlaybackEnd() { return default; }
	///<summary>@return the duration of the sequence in FrameNumber</summary>
	public  FFrameNumber GetCurrentSequenceDuration() { return default; }
	///<summary>@return the current FrameTime of the sequence playback.</summary>
	public  FFrameTime GetCurrentSequencePlaybackPosition() { return default; }
	///<summary>@return The current Timecode of the sequence playback.</summary>
	public  FTimecode GetCurrentSequencePlaybackTimecode() { return default; }
	///<summary>Moves the current sequence to a desired playback position</summary>
	public  void JumpToPlaybackPosition(FFrameNumber InFrameNumber) {}
	///<summary>@return true if a valid LevelSequence is being played.</summary>
	public  bool IsSequencePlaybackActive() { return default; }
	///<summary>Pause the currently active sequence</summary>
	public  void PauseLevelSequence() {}
	///<summary>Starts playing the currently active sequence</summary>
	public  void PlayLevelSequence() {}
	///<summary>Starts playing the currently active sequence in reverse</summary>
	public  void PlayLevelSequenceReverse() {}
	///<summary>Stops playing the currently active sequence</summary>
	public  void StopLevelSequencePlay() {}
	///<summary>Changes the active level sequence to a new level sequence.</summary>
	public  bool SetActiveLevelSequence(ULevelSequence InNewLevelSequence) { return default; }
	///<summary>Clears the current level sequence player, needed when recording clean takes of something.</summary>
	public  void ClearActiveLevelSequence() {}
	///<summary>The sequence to play back</summary>
	public ULevelSequence ActiveLevelSequence;
}
