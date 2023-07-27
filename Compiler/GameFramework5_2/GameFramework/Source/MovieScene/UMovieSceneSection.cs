#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MovieSceneSection.h")]
///<summary>Base class for movie scene sections</summary>
public partial class UMovieSceneSection : UMovieSceneSignedObject {
// MovieSceneSection
	public FMovieSceneSectionEvalOptions EvalOptions;
	public  EMovieSceneCompletionMode GetCompletionMode() { return default; }
	public  void SetCompletionMode(EMovieSceneCompletionMode InCompletionMode) {}
	public  FOptionalMovieSceneBlendType GetBlendType() { return default; }
	public  void SetBlendType(EMovieSceneBlendType InBlendType) {}
	public  void SetRowIndex(int NewRowIndex) {}
	public  int GetRowIndex() { return default; }
	public  void SetOverlapPriority(int NewPriority) {}
	public  int GetOverlapPriority() { return default; }
	public  void SetIsActive(bool bInIsActive) {}
	public  bool IsActive() { return default; }
	public  void SetIsLocked(bool bInIsLocked) {}
	public  bool IsLocked() { return default; }
	public  void SetPreRollFrames(int InPreRollFrames) {}
	public  int GetPreRollFrames() { return default; }
	public  void SetPostRollFrames(int InPostRollFrames) {}
	public  int GetPostRollFrames() { return default; }
	public  void SetColorTint(FColor InColorTint) {}
	public  FColor GetColorTint() { return default; }
	public FMovieSceneEasingSettings Easing;
	public FMovieSceneFrameRange SectionRange;
	public FMovieSceneTimecodeSource TimecodeSource;
	public FFrameNumber PreRollFrames;
	public FFrameNumber PostRollFrames;
	public int RowIndex;
	public int OverlapPriority;
	public bool bIsActive;
	public bool bIsLocked;
	public FColor ColorTint;
	public float StartTime_DEPRECATED;
	public float EndTime_DEPRECATED;
	public float PreRollTime_DEPRECATED;
	public float PostRollTime_DEPRECATED;
	public bool bIsInfinite_DEPRECATED;
	public bool bSupportsInfiniteRange;
	public FOptionalMovieSceneBlendType BlendType;
}
