#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Material output expression for setting the mean free path and scattering distribution properties of subsurface profile (for the Path Tracer Only).</summary>
[CppInclude("Materials/MaterialExpressionSubsurfaceMediumMaterialOutput.h")]
public partial class UMaterialExpressionSubsurfaceMediumMaterialOutput : UMaterialExpressionCustomOutput {
	///<summary>Input for mean free path (cm). Fallback to the default behavior if not set (e.g., Subsurfaceprofile shading: Use the derived MFP)</summary>
	public FExpressionInput MeanFreePath;
	///<summary>Input for scattering distribution. Valid range is (-1, 1). Fallback to zero if not set</summary>
	public FExpressionInput ScatteringDistribution;
}
