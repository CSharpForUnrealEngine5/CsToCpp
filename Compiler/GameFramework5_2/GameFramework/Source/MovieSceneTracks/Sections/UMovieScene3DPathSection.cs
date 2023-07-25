#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Sections/MovieScene3DPathSection.h")]
///<summary>A 3D Path section</summary>
public partial class UMovieScene3DPathSection : UMovieScene3DConstraintSection {
// MovieScene3DPathSection
	public FMovieSceneFloatChannel TimingCurve;
	public MovieScene3DPathSection_Axis FrontAxisEnum;
	public MovieScene3DPathSection_Axis UpAxisEnum;
	public bool bFollow;
	public bool bReverse;
	public bool bForceUpright;
}
