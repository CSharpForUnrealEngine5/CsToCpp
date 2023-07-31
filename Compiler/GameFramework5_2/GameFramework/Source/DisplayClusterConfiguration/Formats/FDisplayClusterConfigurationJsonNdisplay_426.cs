#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>&quot;nDisplay&quot; category structure</summary>
[CppInclude("Formats/JSON426/DisplayClusterConfigurationJsonTypes_426.h")]
public partial struct FDisplayClusterConfigurationJsonNdisplay_426 {
	public string Description;
	public string Version;
	public string AssetPath;
	public FDisplayClusterConfigurationJsonScene_426 Scene;
	public FDisplayClusterConfigurationJsonCluster_426 Cluster;
	public TMap<string,string> CustomParameters;
	public FDisplayClusterConfigurationJsonDiagnostics_426 Diagnostics;
}
