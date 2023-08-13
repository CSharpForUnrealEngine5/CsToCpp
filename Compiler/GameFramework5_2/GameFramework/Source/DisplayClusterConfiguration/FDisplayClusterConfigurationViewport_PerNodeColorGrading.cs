namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DisplayClusterConfigurationTypes_Postprocess.h")]
public partial struct FDisplayClusterConfigurationViewport_PerNodeColorGrading {
	public FText Name;
	public bool bIsEnabled;
	public bool bEntireClusterColorGrading;
	public bool bAllNodesColorGrading;
	public FDisplayClusterConfigurationViewport_ColorGradingRenderingSettings ColorGradingSettings;
	public TArray<string> ApplyPostProcessToObjects;
}
