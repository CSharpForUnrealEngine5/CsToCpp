#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>LiveLink Controller for the LensRole to drive lens distortion data</summary>
[CppInclude("LiveLinkLensController.h")]
public partial class ULiveLinkLensController : ULiveLinkControllerBase {
	public static UClass StaticClass() {return default;}
	///<summary>LensDistortionHandler_DEPRECATED</summary>
	public ULensDistortionModelHandlerBase LensDistortionHandler_DEPRECATED;
	///<summary>DistortionProducerID_DEPRECATED</summary>
	public FGuid DistortionProducerID_DEPRECATED;
	///<summary>bScaleOverscan_DEPRECATED</summary>
	public bool bScaleOverscan_DEPRECATED;
	///<summary>OverscanMultiplier_DEPRECATED</summary>
	public float OverscanMultiplier_DEPRECATED;
}
