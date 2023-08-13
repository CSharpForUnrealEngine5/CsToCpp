namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DisplayClusterMoviePipelineSettings.h")]
public partial struct FDisplayClusterMoviePipelineConfiguration {
	public TSoftObjectPtr<ADisplayClusterRootActor> DCRootActor;
	public bool bUseViewportResolutions;
	public bool bRenderAllViewports;
	public TArray<string> AllowedViewportNamesList;
}
