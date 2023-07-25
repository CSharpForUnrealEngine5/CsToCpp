#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DisplayClusterConfigurationTypes_Postprocess.h")]
public partial struct FDisplayClusterConfigurationViewport_PerNodeColorGrading {
// DisplayClusterConfigurationViewport_PerNodeColorGrading
	public string Name;
	public bool bIsEnabled;
	public bool bEntireClusterColorGrading;
	public bool bAllNodesColorGrading;
	public FDisplayClusterConfigurationViewport_ColorGradingRenderingSettings ColorGradingSettings;
	public TArray<string> ApplyPostProcessToObjects;
}
