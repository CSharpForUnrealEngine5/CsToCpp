#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Formats/JSON426/DisplayClusterConfigurationJsonTypes_426.h")]
///<summary>"nDisplay" category structure</summary>
public partial struct FDisplayClusterConfigurationJsonNdisplay_426 {
// DisplayClusterConfigurationJsonNdisplay_426
	public string Description;
	public string Version;
	public string AssetPath;
	public FDisplayClusterConfigurationJsonScene_426 Scene;
	public FDisplayClusterConfigurationJsonCluster_426 Cluster;
	public TMap<string,string> CustomParameters;
	public FDisplayClusterConfigurationJsonDiagnostics_426 Diagnostics;
}
