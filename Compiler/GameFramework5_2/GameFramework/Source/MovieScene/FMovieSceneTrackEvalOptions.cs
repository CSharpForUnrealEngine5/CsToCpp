#pragma warning disable CS8618,CS8603,CS1587,CS1591
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
