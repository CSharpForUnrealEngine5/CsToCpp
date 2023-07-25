#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("LiveLinkLensController.h")]
///<summary>LiveLink Controller for the LensRole to drive lens distortion data</summary>
public partial class ULiveLinkLensController : ULiveLinkControllerBase {
// LiveLinkLensController
	public ULensDistortionModelHandlerBase LensDistortionHandler_DEPRECATED;
	public FGuid DistortionProducerID_DEPRECATED;
	public bool bScaleOverscan_DEPRECATED;
	public float OverscanMultiplier_DEPRECATED;
}
