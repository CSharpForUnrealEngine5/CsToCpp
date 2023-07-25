#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Sections/MovieSceneCameraCutSection.h")]
///<summary>Movie CameraCuts are sections on the CameraCuts track, that show what the viewer "sees"</summary>
public partial class UMovieSceneCameraCutSection : UMovieSceneSection {
// MovieSceneCameraCutSection
	public FMovieSceneObjectBindingID GetCameraBindingID() { return default; }
	public void SetCameraBindingID(FMovieSceneObjectBindingID InCameraBindingID) {}
	public bool bLockPreviousCamera;
	public FGuid CameraGuid_DEPRECATED;
	public FMovieSceneObjectBindingID CameraBindingID;
	public FTransform InitialCameraCutTransform;
	public bool bHasInitialCameraCutTransform;
	public float ThumbnailReferenceOffset;
}
