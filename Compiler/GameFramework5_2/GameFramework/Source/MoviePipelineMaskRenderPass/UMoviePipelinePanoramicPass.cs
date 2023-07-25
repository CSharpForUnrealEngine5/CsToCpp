#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MoviePipelinePanoramicPass.h")]
///<summary>Generates a panoramic image (potentially in stereo, stored top/bottom in the final sheet) in equirectangular projection space.</summary>
public partial class UMoviePipelinePanoramicPass : UMoviePipelineImagePassBase {
// MoviePipelinePanoramicPass
	public int NumHorizontalSteps;
	public int NumVerticalSteps;
	public float HorzFieldOfView;
	public float VertFieldOfView;
	public bool bAllocateHistoryPerPane;
}
