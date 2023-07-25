#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DisplayClusterMoviePipelineSettings.h")]
public partial struct FDisplayClusterMoviePipelineConfiguration {
// DisplayClusterMoviePipelineConfiguration
	public TSoftObjectPtr<ADisplayClusterRootActor> DCRootActor;
	public bool bUseViewportResolutions;
	public bool bRenderAllViewports;
	public TArray<string> AllowedViewportNamesList;
}
