namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MoviePipelineBase.h")]
public partial class UMoviePipelineBase : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Request the movie pipeline to shut down at the next available time. The pipeline will attempt to abandon</summary>
	public void RequestShutdown(bool bIsError/*=false*/) {}
	///<summary>Abandons any future work on this Movie Pipeline and runs through the shutdown flow to ensure already</summary>
	public void Shutdown(bool bIsError/*=false*/) {}
	///<summary>Has RequestShutdown() been called?</summary>
	public bool IsShutdownRequested() { return default; }
	///<summary>GetPipelineState</summary>
	public EMovieRenderPipelineState GetPipelineState() { return default; }
}
