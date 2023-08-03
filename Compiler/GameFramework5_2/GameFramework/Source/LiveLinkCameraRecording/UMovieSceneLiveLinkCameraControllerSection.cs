#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Movie Scene section for LiveLink Camera Controller properties</summary>
[CppInclude("MovieSceneLiveLinkCameraControllerSection.h")]
public partial class UMovieSceneLiveLinkCameraControllerSection : UMovieSceneHookSection {
	public static UClass StaticClass() {return default;}
	///<summary>If true, the Cached Lens File will be evaluated for nodal offset, and that offset will be applied to the transform of the CameraComponent</summary>
	public bool bApplyNodalOffsetFromCachedLensFile;
	///<summary>Saved duplicate of the LensFile asset used by the recorded LiveLink Camera Controller at the time of recording</summary>
	public ULensFile CachedLensFile;
}
