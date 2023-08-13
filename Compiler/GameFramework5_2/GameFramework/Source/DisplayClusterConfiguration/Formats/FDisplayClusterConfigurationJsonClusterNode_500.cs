namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Formats/JSON500/DisplayClusterConfigurationJsonTypes_500.h")]
public partial struct FDisplayClusterConfigurationJsonClusterNode_500 {
	public string Host;
	public bool Sound;
	public bool FullScreen;
	public bool RenderHeadless;
	public int GraphicsAdapter;
	public bool TextureShare;
	public FDisplayClusterConfigurationJsonRectangle_500 Window;
	public TMap<string,FDisplayClusterConfigurationJsonPostprocess_500> Postprocess;
	public TMap<string,FDisplayClusterConfigurationJsonViewport_500> Viewports;
	public FDisplayClusterConfigurationFramePostProcess_OutputRemap_500 OutputRemap;
}
