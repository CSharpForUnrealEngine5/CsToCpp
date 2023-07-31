#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Generates a panoramic image (potentially in stereo, stored top/bottom in the final sheet) in equirectangular projection space.</summary>
[CppInclude("MoviePipelinePanoramicPass.h")]
public partial class UMoviePipelinePanoramicPass : UMoviePipelineImagePassBase {
	///<summary>How many different renders should the 360* horizontal view be broken into? Higher numbers are less distorted but longer to render.</summary>
	public int NumHorizontalSteps;
	///<summary>How many different renders should the 360* vertical view be broken into? Higher numbers are less distorted but longer to render.</summary>
	public int NumVerticalSteps;
	///<summary>Advance used only. Allows you to override the Horizontal Field of View (if not zero). Can cause crashes or incomplete panoramas.</summary>
	public float HorzFieldOfView;
	///<summary>Advance used only. Allows you to override the Vertical Field of View (if not zero). Can cause crashes or incomplete panoramas.</summary>
	public float VertFieldOfView;
	///<summary>Should we store the render scene history per individual render? This can consume a great deal of memory with many renders,</summary>
	public bool bAllocateHistoryPerPane;
}
