namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>nDisplay settings for MoviePipeline</summary>
[CppInclude("DisplayClusterMoviePipelineSettings.h")]
public partial class UDisplayClusterMoviePipelineSettings : UMoviePipelineSetting {
	public static UClass StaticClass() {return default;}
	///<summary>Reference to Display Cluster Root Actor</summary>
	public FDisplayClusterMoviePipelineConfiguration Configuration;
}
