#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DisplayClusterConfigurationTypes_Viewport.h")]
public partial class UDisplayClusterConfigurationViewport : UDisplayClusterConfigurationData_Base {
	public static UClass StaticClass() {return default;}
	///<summary>Enables or disables rendering of this specific Viewport</summary>
	public bool bAllowRendering;
	///<summary>Reference to the nDisplay View Origin</summary>
	public string Camera;
	///<summary>Specify your Projection Policy Settings</summary>
	public FDisplayClusterConfigurationProjection ProjectionPolicy;
	///<summary>bAllowPreviewFrustumRendering</summary>
	public bool bAllowPreviewFrustumRendering;
	///<summary>Define the Viewport 2D coordinates</summary>
	public FDisplayClusterConfigurationRectangle Region;
	///<summary>Define the Viewport Remap settings</summary>
	public FDisplayClusterConfigurationViewport_Remap ViewportRemap;
	///<summary>Allows Viewports to overlap and sets Viewport overlapping order priority</summary>
	public int OverlapOrder;
	///<summary>Specify which GPU should render this Viewport. &quot;-1&quot; is default.</summary>
	public int GPUIndex;
	///<summary>Configure render for this viewport</summary>
	public FDisplayClusterConfigurationViewport_RenderSettings RenderSettings;
	///<summary>Configure ICVFX for this viewport</summary>
	public FDisplayClusterConfigurationViewport_ICVFX ICVFX;
	///<summary>Locks the Viewport aspect ratio for easier resizing</summary>
	public bool bFixedAspectRatio;
	///<summary>bIsUnlocked</summary>
	public bool bIsUnlocked;
	///<summary>bIsVisible</summary>
	public bool bIsVisible;
}
