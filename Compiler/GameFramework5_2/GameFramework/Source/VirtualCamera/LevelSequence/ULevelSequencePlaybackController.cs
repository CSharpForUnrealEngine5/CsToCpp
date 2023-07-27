#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("LevelSequence/LevelSequencePlaybackController.h")]
public partial class ULevelSequencePlaybackController : UObject {
// LevelSequencePlaybackController
	public  void GetLevelSequences(TArray<FLevelSequenceData> OutLevelSequenceNames) {}
	public  string GetActiveLevelSequenceName() { return default; }
	public  ULevelSequence GetActiveLevelSequence() { return default; }
	public  FFrameRate GetCurrentSequenceFrameRate() { return default; }
	public  bool IsSequencerLockedToCameraCut() { return default; }
	public  void SetSequencerLockedToCameraCut(bool bLockView) {}
	public  FFrameNumber GetCurrentSequencePlaybackStart() { return default; }
	public  FFrameNumber GetCurrentSequencePlaybackEnd() { return default; }
	public  FFrameNumber GetCurrentSequenceDuration() { return default; }
	public  FFrameTime GetCurrentSequencePlaybackPosition() { return default; }
	public  FTimecode GetCurrentSequencePlaybackTimecode() { return default; }
	public  void JumpToPlaybackPosition(FFrameNumber InFrameNumber) {}
	public  bool IsSequencePlaybackActive() { return default; }
	public  void PauseLevelSequence() {}
	public  void PlayLevelSequence() {}
	public  void PlayLevelSequenceReverse() {}
	public  void StopLevelSequencePlay() {}
	public  bool SetActiveLevelSequence(ULevelSequence InNewLevelSequence) { return default; }
	public  void ClearActiveLevelSequence() {}
	public ULevelSequence ActiveLevelSequence;
}
