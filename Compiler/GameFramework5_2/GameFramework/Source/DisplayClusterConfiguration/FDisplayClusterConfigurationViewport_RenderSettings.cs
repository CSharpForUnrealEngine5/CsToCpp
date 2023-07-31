#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DisplayClusterConfigurationTypes_Viewport.h")]
public partial struct FDisplayClusterConfigurationViewport_RenderSettings {
	public bool bEnableCrossGPUTransfer;
	public int StereoGPUIndex;
	public EDisplayClusterConfigurationViewport_StereoMode StereoMode;
	public float BufferRatio;
	public float RenderTargetRatio;
	public FDisplayClusterConfigurationViewport_CustomPostprocess CustomPostprocess;
	public FDisplayClusterConfigurationPostRender_Override Replace;
	public FDisplayClusterConfigurationPostRender_BlurPostprocess PostprocessBlur;
	public FDisplayClusterConfigurationPostRender_GenerateMips GenerateMips;
	public FDisplayClusterConfigurationViewport_Overscan Overscan;
	public FDisplayClusterConfigurationMedia Media;
	public int RenderFamilyGroup;
}
