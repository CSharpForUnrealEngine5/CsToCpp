#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("LiveLinkCameraController.h")]
public partial class ULiveLinkCameraController : ULiveLinkControllerBase {
	public static UClass StaticClass() {return default;}
	///<summary>ComponentToControl_DEPRECATED</summary>
	public FComponentReference ComponentToControl_DEPRECATED;
	///<summary>TransformData_DEPRECATED</summary>
	public FLiveLinkTransformControllerData TransformData_DEPRECATED;
	///<summary>Should LiveLink inputs be remapped (i.e normalized to physical units) using camera component range</summary>
	public bool bUseCameraRange;
	///<summary>Asset containing encoder and fiz mapping</summary>
	public FLensFilePicker LensFilePicker;
	///<summary>bApplyNodalOffset_DEPRECATED</summary>
	public bool bApplyNodalOffset_DEPRECATED;
	///<summary>bUseCroppedFilmback_DEPRECATED</summary>
	public bool bUseCroppedFilmback_DEPRECATED;
	///<summary>CroppedFilmback_DEPRECATED</summary>
	public FCameraFilmbackSettings CroppedFilmback_DEPRECATED;
	///<summary>bScaleOverscan_DEPRECATED</summary>
	public bool bScaleOverscan_DEPRECATED;
	///<summary>OverscanMultiplier_DEPRECATED</summary>
	public float OverscanMultiplier_DEPRECATED;
	///<summary>OriginalCameraRotation_DEPRECATED</summary>
	public FRotator OriginalCameraRotation_DEPRECATED;
	///<summary>OriginalCameraLocation_DEPRECATED</summary>
	public FVector OriginalCameraLocation_DEPRECATED;
	///<summary>LensDistortionHandler_DEPRECATED</summary>
	public ULensDistortionModelHandlerBase LensDistortionHandler_DEPRECATED;
	///<summary>DistortionProducerID_DEPRECATED</summary>
	public FGuid DistortionProducerID_DEPRECATED;
	///<summary>Used to control which data from LiveLink is actually applied to camera</summary>
	public FLiveLinkCameraControllerUpdateFlags UpdateFlags;
	///<summary>Whether to refresh frustum drawing on value change</summary>
	public bool bShouldUpdateVisualComponentOnChange;
}
