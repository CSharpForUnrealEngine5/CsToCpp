#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Base class for Movie Pipeline functional tests which render pre-made queues</summary>
[CppInclude("MoviePipelineFunctionalTestBase.h")]
public partial class AMoviePipelineFunctionalTestBase : AFunctionalTest {
	///<summary>QueuePreset</summary>
	public UMoviePipelineQueue QueuePreset;
	///<summary>ActiveMoviePipeline</summary>
	public UMoviePipeline ActiveMoviePipeline;
	///<summary>ActiveQueue</summary>
	public UMoviePipelineQueue ActiveQueue;
}
