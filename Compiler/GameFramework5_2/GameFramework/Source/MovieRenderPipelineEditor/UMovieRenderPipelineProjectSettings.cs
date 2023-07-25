#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MovieRenderPipelineSettings.h")]
///<summary>Universal Movie Render Pipeline settings that apply to the whole project.</summary>
public partial class UMovieRenderPipelineProjectSettings : UObject {
// MovieRenderPipelineProjectSettings
	public FDirectoryPath PresetSaveDir;
	public TSoftObjectPtr<UMoviePipelinePrimaryConfig> LastPresetOrigin;
	public FSoftClassPath DefaultLocalExecutor;
	public FSoftClassPath DefaultRemoteExecutor;
	public FSoftClassPath DefaultExecutorJob;
	public FSoftClassPath DefaultPipeline;
	public TArray<FSoftClassPath> DefaultClasses;
}
