#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Flags to control whether incoming values from LiveLink Camera FrameData should be applied or not</summary>
[CppInclude("LiveLinkCameraController.h")]
public partial struct FLiveLinkCameraControllerUpdateFlags {
	public bool bApplyFieldOfView;
	public bool bApplyAspectRatio;
	public bool bApplyFocalLength;
	public bool bApplyProjectionMode;
	public bool bApplyFilmBack;
	public bool bApplyAperture;
	public bool bApplyFocusDistance;
}
