#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Sections/MovieScene3DTransformSection.h")]
///<summary>A 3D transform section</summary>
public partial class UMovieScene3DTransformSection : UMovieSceneSection {
// MovieScene3DTransformSection
	public FMovieSceneTransformMask TransformMask;
	public FMovieSceneDoubleChannel Translation;
	public FMovieSceneDoubleChannel Rotation;
	public FMovieSceneDoubleChannel Scale;
	public FMovieSceneFloatChannel ManualWeight;
	public UMovieSceneSectionChannelOverrideRegistry OverrideRegistry;
	public UMovieScene3DTransformSectionConstraints Constraints;
	public bool bUseQuaternionInterpolation;
	public EShow3DTrajectory Show3DTrajectory;
}
