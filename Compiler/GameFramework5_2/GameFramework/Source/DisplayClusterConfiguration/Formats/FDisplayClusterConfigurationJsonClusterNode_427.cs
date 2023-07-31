#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Formats/JSON427/DisplayClusterConfigurationJsonTypes_427.h")]
public partial struct FDisplayClusterConfigurationJsonClusterNode_427 {
	public string Host;
	public bool Sound;
	public bool FullScreen;
	public FDisplayClusterConfigurationJsonRectangle_427 Window;
	public TMap<string,FDisplayClusterConfigurationJsonPostprocess_427> Postprocess;
	public TMap<string,FDisplayClusterConfigurationJsonViewport_427> Viewports;
	public FDisplayClusterConfigurationFramePostProcess_OutputRemap_427 OutputRemap;
}
