#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Base class for movie scene sections</summary>
[CppInclude("MovieSceneSection.h")]
public partial class UMovieSceneSection : UMovieSceneSignedObject {
	public static UClass StaticClass() {return default;}
	///<summary>EvalOptions</summary>
	public FMovieSceneSectionEvalOptions EvalOptions;
	///<summary>Gets this section&#39;s completion mode</summary>
	public  EMovieSceneCompletionMode GetCompletionMode() { return default; }
	///<summary>* Sets this section&#39;s completion mode</summary>
	public  void SetCompletionMode(EMovieSceneCompletionMode InCompletionMode) {}
	///<summary>Gets this section&#39;s blend type</summary>
	public  FOptionalMovieSceneBlendType GetBlendType() { return default; }
	///<summary>Sets this section&#39;s blend type</summary>
	public  void SetBlendType(EMovieSceneBlendType InBlendType) {}
	///<summary>Sets this section&#39;s new row index</summary>
	public  void SetRowIndex(int NewRowIndex) {}
	///<summary>Gets the row index for this section</summary>
	public  int GetRowIndex() { return default; }
	///<summary>Sets this section&#39;s priority over overlapping sections (higher wins)</summary>
	public  void SetOverlapPriority(int NewPriority) {}
	///<summary>Gets this section&#39;s priority over overlapping sections (higher wins)</summary>
	public  int GetOverlapPriority() { return default; }
	///<summary>Whether or not this section is active.</summary>
	public  void SetIsActive(bool bInIsActive) {}
	///<summary>IsActive</summary>
	public  bool IsActive() { return default; }
	///<summary>Whether or not this section is locked.</summary>
	public  void SetIsLocked(bool bInIsLocked) {}
	///<summary>IsLocked</summary>
	public  bool IsLocked() { return default; }
	///<summary>Gets the number of frames to prepare this section for evaluation before it actually starts.</summary>
	public  void SetPreRollFrames(int InPreRollFrames) {}
	///<summary>GetPreRollFrames</summary>
	public  int GetPreRollFrames() { return default; }
	///<summary>Gets/sets the number of frames to continue &#39;postrolling&#39; this section for after evaluation has ended.</summary>
	public  void SetPostRollFrames(int InPostRollFrames) {}
	///<summary>GetPostRollFrames</summary>
	public  int GetPostRollFrames() { return default; }
	///<summary>Set this section&#39;s color tint.</summary>
	public  void SetColorTint(FColor InColorTint) {}
	///<summary>Get this section&#39;s color tint.</summary>
	public  FColor GetColorTint() { return default; }
	///<summary>Easing</summary>
	public FMovieSceneEasingSettings Easing;
	///<summary>The range in which this section is active</summary>
	public FMovieSceneFrameRange SectionRange;
	///<summary>The timecode at which this movie scene section is based (ie. when it was recorded)</summary>
	public FMovieSceneTimecodeSource TimecodeSource;
	///<summary>The amount of time to prepare this section for evaluation before it actually starts.</summary>
	public FFrameNumber PreRollFrames;
	///<summary>The amount of time to continue &#39;postrolling&#39; this section for after evaluation has ended.</summary>
	public FFrameNumber PostRollFrames;
	///<summary>The row index that this section sits on</summary>
	public int RowIndex;
	///<summary>This section&#39;s priority over overlapping sections</summary>
	public int OverlapPriority;
	///<summary>Toggle whether this section is active/inactive</summary>
	public bool bIsActive;
	///<summary>Toggle whether this section is locked/unlocked</summary>
	public bool bIsLocked;
	///<summary>The color tint for this section</summary>
	public FColor ColorTint;
	///<summary>The start time of the section</summary>
	public float StartTime_DEPRECATED;
	///<summary>The end time of the section</summary>
	public float EndTime_DEPRECATED;
	///<summary>The amount of time to prepare this section for evaluation before it actually starts.</summary>
	public float PreRollTime_DEPRECATED;
	///<summary>The amount of time to continue &#39;postrolling&#39; this section for after evaluation has ended.</summary>
	public float PostRollTime_DEPRECATED;
	///<summary>Toggle to set this section to be infinite</summary>
	public bool bIsInfinite_DEPRECATED;
	///<summary>Does this section support infinite ranges in the track editor?</summary>
	public bool bSupportsInfiniteRange;
	///<summary>BlendType</summary>
	public FOptionalMovieSceneBlendType BlendType;
}
