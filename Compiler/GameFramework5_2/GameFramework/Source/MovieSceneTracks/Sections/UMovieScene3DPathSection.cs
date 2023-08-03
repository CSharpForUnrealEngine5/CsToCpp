#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A 3D Path section</summary>
[CppInclude("Sections/MovieScene3DPathSection.h")]
public partial class UMovieScene3DPathSection : UMovieScene3DConstraintSection {
	public static UClass StaticClass() {return default;}
	///<summary>Timing Curve</summary>
	public FMovieSceneFloatChannel TimingCurve;
	///<summary>Front Axis</summary>
	public MovieScene3DPathSection_Axis FrontAxisEnum;
	///<summary>Up Axis</summary>
	public MovieScene3DPathSection_Axis UpAxisEnum;
	///<summary>Follow Curve</summary>
	public bool bFollow;
	///<summary>Reverse Timing</summary>
	public bool bReverse;
	///<summary>Force Upright</summary>
	public bool bForceUpright;
}
