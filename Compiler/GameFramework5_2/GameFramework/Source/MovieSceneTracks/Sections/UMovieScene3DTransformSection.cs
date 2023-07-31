#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A 3D transform section</summary>
[CppInclude("Sections/MovieScene3DTransformSection.h")]
public partial class UMovieScene3DTransformSection : UMovieSceneSection {
	///<summary>TransformMask</summary>
	public FMovieSceneTransformMask TransformMask;
	///<summary>Translation curves</summary>
	public FMovieSceneDoubleChannel Translation;
	///<summary>Rotation curves</summary>
	public FMovieSceneDoubleChannel Rotation;
	///<summary>Scale curves</summary>
	public FMovieSceneDoubleChannel Scale;
	///<summary>Manual weight curve</summary>
	public FMovieSceneFloatChannel ManualWeight;
	///<summary>Optional pointer to a &quot;channels override&quot; container object. This object would only be allocated if any channels are overridden with a non-standard channel</summary>
	public UMovieSceneSectionChannelOverrideRegistry OverrideRegistry;
	///<summary>Optional pointer to constraint channels</summary>
	public UMovieScene3DTransformSectionConstraints Constraints;
	///<summary>Whether to use a quaternion linear interpolation between keys. This finds the &#39;shortest&#39; rotation between keyed orientations.</summary>
	public bool bUseQuaternionInterpolation;
	///<summary>Whether to show the 3d trajectory</summary>
	public EShow3DTrajectory Show3DTrajectory;
}
