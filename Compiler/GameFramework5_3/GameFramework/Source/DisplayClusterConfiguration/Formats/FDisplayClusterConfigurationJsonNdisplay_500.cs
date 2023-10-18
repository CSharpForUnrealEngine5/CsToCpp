namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>&quot;nDisplay&quot; category structure</summary>
[CppInclude("Formats/JSON500/DisplayClusterConfigurationJsonTypes_500.h")]
public partial struct FDisplayClusterConfigurationJsonNdisplay_500 {
	public string Description;
	public string Version;
	public string AssetPath;
	public FDisplayClusterConfigurationJsonMisc_500 Misc;
	public FDisplayClusterConfigurationJsonScene_500 Scene;
	public FDisplayClusterConfigurationJsonCluster_500 Cluster;
	public TMap<string,string> CustomParameters;
	public FDisplayClusterConfigurationJsonDiagnostics_500 Diagnostics;
}
