#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DisplayClusterConfigurationTypes.h")]
public partial class UDisplayClusterConfigurationClusterNode : UDisplayClusterConfigurationData_Base {
	public static UClass StaticClass() {return default;}
	///<summary>GetViewportIds</summary>
	public  void GetViewportIds(TArray<string> OutViewportIds) {}
	///<summary>GetViewport</summary>
	public  UDisplayClusterConfigurationViewport GetViewport(string ViewportId) { return default; }
	///<summary>Return all references to meshes from policy, and other</summary>
	public  void GetReferencedMeshNames(TArray<string> OutMeshNames) {}
	///<summary>IP address of this specific cluster Node</summary>
	public string Host;
	///<summary>Enables or disables sound on nDisplay primary Node</summary>
	public bool bIsSoundEnabled;
	///<summary>Enables application window native fullscreen support</summary>
	public bool bIsFullscreen;
	///<summary>Defines the application window size in pixels</summary>
	public FDisplayClusterConfigurationRectangle WindowRect;
	///<summary>Output remapping settings for the selected cluster node</summary>
	public FDisplayClusterConfigurationFramePostProcess_OutputRemap OutputRemap;
	///<summary>Activates headless rendering for this cluster node</summary>
	public bool bRenderHeadless;
	///<summary>Hint for setting the r.GraphicsAdapter CVar when launching this cluster node. Note that this is distinct from the GPU Node Indices assigned to viewports.</summary>
	public int GraphicsAdapter;
	///<summary>Enables texture sharing for this cluster node</summary>
	public bool bEnableTextureShare;
	///<summary>Locks the application window aspect ratio for easier resizing</summary>
	public bool bFixedAspectRatio;
	///<summary>Viewports</summary>
	public TMap<string,UDisplayClusterConfigurationViewport> Viewports;
	///<summary>Postprocess</summary>
	public TMap<string,FDisplayClusterConfigurationPostprocess> Postprocess;
	///<summary>Media settings</summary>
	public FDisplayClusterConfigurationMedia Media;
	///<summary>bIsVisible</summary>
	public bool bIsVisible;
	///<summary>bIsUnlocked</summary>
	public bool bIsUnlocked;
	///<summary>Binds a background preview image for easier output mapping</summary>
	public FDisplayClusterConfigurationExternalImage PreviewImage;
}
