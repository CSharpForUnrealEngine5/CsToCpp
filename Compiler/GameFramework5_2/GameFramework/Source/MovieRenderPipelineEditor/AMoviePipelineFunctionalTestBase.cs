#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MoviePipelineFunctionalTestBase.h")]
///<summary>Base class for Movie Pipeline functional tests which render pre-made queues</summary>
public partial class AMoviePipelineFunctionalTestBase : AFunctionalTest {
// MoviePipelineFunctionalTestBase
	public UMoviePipelineQueue QueuePreset;
	public UMoviePipeline ActiveMoviePipeline;
	public UMoviePipelineQueue ActiveQueue;
}
