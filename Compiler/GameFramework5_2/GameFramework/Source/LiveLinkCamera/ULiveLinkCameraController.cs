#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("LiveLinkCameraController.h")]
public partial class ULiveLinkCameraController : ULiveLinkControllerBase {
// LiveLinkCameraController
	public FComponentReference ComponentToControl_DEPRECATED;
	public FLiveLinkTransformControllerData TransformData_DEPRECATED;
	public bool bUseCameraRange;
	public FLensFilePicker LensFilePicker;
	public bool bApplyNodalOffset_DEPRECATED;
	public bool bUseCroppedFilmback_DEPRECATED;
	public FCameraFilmbackSettings CroppedFilmback_DEPRECATED;
	public bool bScaleOverscan_DEPRECATED;
	public float OverscanMultiplier_DEPRECATED;
	public FRotator OriginalCameraRotation_DEPRECATED;
	public FVector OriginalCameraLocation_DEPRECATED;
	public ULensDistortionModelHandlerBase LensDistortionHandler_DEPRECATED;
	public FGuid DistortionProducerID_DEPRECATED;
	public FLiveLinkCameraControllerUpdateFlags UpdateFlags;
	public bool bShouldUpdateVisualComponentOnChange;
}
