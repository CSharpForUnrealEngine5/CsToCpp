#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Formats/JSON426/DisplayClusterConfigurationJsonTypes_426.h")]
public partial struct FDisplayClusterConfigurationJsonClusterNode_426 {
	public string Host;
	public bool Sound;
	public bool FullScreen;
	public FDisplayClusterConfigurationJsonRectangle_426 Window;
	public TMap<string,FDisplayClusterConfigurationJsonPostprocess_426> Postprocess;
	public TMap<string,FDisplayClusterConfigurationJsonViewport_426> Viewports;
}
