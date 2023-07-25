#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DisplayClusterConfigurationTypes_Viewport.h")]
public partial class UDisplayClusterConfigurationViewport : UDisplayClusterConfigurationData_Base {
// DisplayClusterConfigurationViewport
	public bool bAllowRendering;
	public string Camera;
	public FDisplayClusterConfigurationProjection ProjectionPolicy;
	public bool bAllowPreviewFrustumRendering;
	public FDisplayClusterConfigurationRectangle Region;
	public FDisplayClusterConfigurationViewport_Remap ViewportRemap;
	public int OverlapOrder;
	public int GPUIndex;
	public FDisplayClusterConfigurationViewport_RenderSettings RenderSettings;
	public FDisplayClusterConfigurationViewport_ICVFX ICVFX;
	public bool bFixedAspectRatio;
	public bool bIsUnlocked;
	public bool bIsVisible;
}
