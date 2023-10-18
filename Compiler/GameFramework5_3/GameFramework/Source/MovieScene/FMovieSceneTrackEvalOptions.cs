namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Generic evaluation options for any track</summary>
[CppInclude("MovieSceneTrack.h")]
public partial struct FMovieSceneTrackEvalOptions {
	public bool bCanEvaluateNearestSection;
	public bool bEvalNearestSection;
	public bool bEvaluateInPreroll;
	public bool bEvaluateInPostroll;
	public bool bEvaluateNearestSection_DEPRECATED;
}
