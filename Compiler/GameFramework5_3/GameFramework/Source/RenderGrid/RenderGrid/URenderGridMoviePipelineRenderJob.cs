namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>This class is responsible for the movie pipeline part of the rendering of the given render grid job.</summary>
[CppInclude("RenderGrid/RenderGridQueue.h")]
public partial class URenderGridMoviePipelineRenderJob : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>The render grid job that will be rendered.</summary>
	public URenderGridJob RenderGridJob;
	///<summary>The render grid that the render grid job (that will be rendered) belongs to.</summary>
	public URenderGrid RenderGrid;
	///<summary>The movie pipeline queue.</summary>
	public UMoviePipelineQueue PipelineQueue;
	///<summary>The movie pipeline executor.</summary>
	public UMoviePipelineExecutorBase PipelineExecutor;
	///<summary>The movie pipeline executor job of the given render grid job.</summary>
	public UMoviePipelineExecutorJob PipelineExecutorJob;
	///<summary>The rendering status of the given render grid job.</summary>
	public string Status;
	///<summary>Whether the entry can execute, or whether it should just skip execution.</summary>
	public bool bCanExecute;
	///<summary>Whether the entry was canceled (like by calling Cancel(), or by closing the render popup).</summary>
	public bool bCanceled;
	///<summary>Whether the entry has finished (or was canceled).</summary>
	public bool bFinished;
}
