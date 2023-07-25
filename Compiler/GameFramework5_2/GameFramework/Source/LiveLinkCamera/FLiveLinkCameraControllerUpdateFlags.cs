#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("LiveLinkCameraController.h")]
///<summary>Flags to control whether incoming values from LiveLink Camera FrameData should be applied or not</summary>
public partial struct FLiveLinkCameraControllerUpdateFlags {
// LiveLinkCameraControllerUpdateFlags
	public bool bApplyFieldOfView;
	public bool bApplyAspectRatio;
	public bool bApplyFocalLength;
	public bool bApplyProjectionMode;
	public bool bApplyFilmBack;
	public bool bApplyAperture;
	public bool bApplyFocusDistance;
}
