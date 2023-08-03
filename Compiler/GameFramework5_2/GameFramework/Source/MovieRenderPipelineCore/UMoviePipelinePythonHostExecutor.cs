#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>This is a dummy executor that is designed to host a executor implemented in</summary>
[CppInclude("MoviePipelinePythonHostExecutor.h")]
public partial class UMoviePipelinePythonHostExecutor : UMoviePipelineExecutorBase {
	public static UClass StaticClass() {return default;}
	///<summary>Python/Blueprint API</summary>
	public  void ExecuteDelayed(UMoviePipelineQueue InPipelineQueue) {}
	///<summary>OnMapLoad</summary>
	public  void OnMapLoad(UWorld InWorld) {}
	///<summary>~Python/Blueprint API</summary>
	public  UWorld GetLastLoadedWorld() { return default; }
	///<summary>You should override this class type on the CDO of the object with your Python type when Python is initialized.</summary>
	public UClass ExecutorClass;
	///<summary>PipelineQueue</summary>
	public UMoviePipelineQueue PipelineQueue;
	///<summary>LastLoadedWorld</summary>
	public UWorld LastLoadedWorld;
}
