namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>This executor implementation can process an array of movie pipelines and</summary>
[CppInclude("MoviePipelineInProcessExecutor.h")]
public partial class UMoviePipelineInProcessExecutor : UMoviePipelineLinearExecutorBase {
	public static UClass StaticClass() {return default;}
	///<summary>Use current level instead of opening new level</summary>
	public bool bUseCurrentLevel;
}
