namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Universal Movie Render Pipeline settings that apply to the whole project.</summary>
[CppInclude("MovieRenderPipelineSettings.h")]
public partial class UMovieRenderPipelineProjectSettings : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Which directory should we try to save presets in by default?</summary>
	public FDirectoryPath PresetSaveDir;
	///<summary>What was the last configuration preset the user used? Can be null.</summary>
	public TSoftObjectPtr<UMoviePipelinePrimaryConfig> LastPresetOrigin;
	///<summary>When the user uses the UI to request we render a movie locally, which implementation should we use</summary>
	public FSoftClassPath DefaultLocalExecutor;
	///<summary>When the user uses the UI to request we render a movie remotely, which implementation should we use</summary>
	public FSoftClassPath DefaultRemoteExecutor;
	///<summary>Which Job class should we create by default when adding a job? This allows you to make custom jobs</summary>
	public FSoftClassPath DefaultExecutorJob;
	///<summary>This allows you to implement your own Pipeline to handle timing and rendering of a movie. Changing</summary>
	public FSoftClassPath DefaultPipeline;
	///<summary>The settings specified here will automatically be added to a Movie Pipeline Primary Configuration when using the UI.</summary>
	public TArray<FSoftClassPath> DefaultClasses;
}
