#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Movie CameraCuts are sections on the CameraCuts track, that show what the viewer &quot;sees&quot;</summary>
[CppInclude("Sections/MovieSceneCameraCutSection.h")]
public partial class UMovieSceneCameraCutSection : UMovieSceneSection {
	public static UClass StaticClass() {return default;}
	///<summary>Gets the camera binding for this CameraCut section</summary>
	public  FMovieSceneObjectBindingID GetCameraBindingID() { return default; }
	///<summary>Sets the camera binding for this CameraCut section</summary>
	public  void SetCameraBindingID(FMovieSceneObjectBindingID InCameraBindingID) {}
	///<summary>When blending, lock the previous camera (camera cut or gameplay camera).</summary>
	public bool bLockPreviousCamera;
	///<summary>The camera possessable or spawnable that this movie CameraCut uses</summary>
	public FGuid CameraGuid_DEPRECATED;
	///<summary>The camera binding that this movie CameraCut uses</summary>
	public FMovieSceneObjectBindingID CameraBindingID;
	///<summary>Camera transform at the start of the cut, computed at compile time</summary>
	public FTransform InitialCameraCutTransform;
	///<summary>bHasInitialCameraCutTransform</summary>
	public bool bHasInitialCameraCutTransform;
	///<summary>The reference frame offset for single thumbnail rendering</summary>
	public float ThumbnailReferenceOffset;
}
