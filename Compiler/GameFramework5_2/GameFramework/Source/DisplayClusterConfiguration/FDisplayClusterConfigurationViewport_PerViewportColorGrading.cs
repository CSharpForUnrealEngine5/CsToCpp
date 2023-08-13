namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DisplayClusterConfigurationTypes_Postprocess.h")]
public partial struct FDisplayClusterConfigurationViewport_PerViewportColorGrading {
	public FText Name;
	public bool bIsEnabled;
	public bool bIsEntireClusterEnabled;
	public FDisplayClusterConfigurationViewport_ColorGradingRenderingSettings ColorGradingSettings;
	public TArray<string> ApplyPostProcessToObjects;
}
