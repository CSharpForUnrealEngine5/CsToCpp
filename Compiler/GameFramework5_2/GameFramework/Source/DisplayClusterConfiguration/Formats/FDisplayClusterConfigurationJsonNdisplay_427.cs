namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>&quot;nDisplay&quot; category structure</summary>
[CppInclude("Formats/JSON427/DisplayClusterConfigurationJsonTypes_427.h")]
public partial struct FDisplayClusterConfigurationJsonNdisplay_427 {
	public string Description;
	public string Version;
	public string AssetPath;
	public FDisplayClusterConfigurationJsonMisc_427 Misc;
	public FDisplayClusterConfigurationJsonScene_427 Scene;
	public FDisplayClusterConfigurationJsonCluster_427 Cluster;
	public TMap<string,string> CustomParameters;
	public FDisplayClusterConfigurationJsonDiagnostics_427 Diagnostics;
}
