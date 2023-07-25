#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DisplayClusterConfigurationTypes_Viewport.h")]
///<summary>This struct now stored in UDisplayClusterConfigurationData, and replicated with MultiUser</summary>
public partial struct FDisplayClusterConfigurationRenderFrame {
// DisplayClusterConfigurationRenderFrame
	public bool bAllowRenderTargetAtlasing;
	public EDisplayClusterConfigurationRenderFamilyMode ViewFamilyMode;
	public bool bShouldUseParentViewportRenderFamily;
	public float ClusterRenderTargetRatioMult;
	public float ClusterICVFXInnerViewportRenderTargetRatioMult;
	public float ClusterICVFXOuterViewportRenderTargetRatioMult;
	public float ClusterBufferRatioMult;
	public float ClusterICVFXInnerFrustumBufferRatioMult;
	public float ClusterICVFXOuterViewportBufferRatioMult;
	public bool bAllowWarpBlend;
}
