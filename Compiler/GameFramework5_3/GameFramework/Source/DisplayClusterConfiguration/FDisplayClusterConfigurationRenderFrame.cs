namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>This struct now stored in UDisplayClusterConfigurationData, and replicated with MultiUser</summary>
[CppInclude("DisplayClusterConfigurationTypes_Viewport.h")]
public partial struct FDisplayClusterConfigurationRenderFrame {
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
