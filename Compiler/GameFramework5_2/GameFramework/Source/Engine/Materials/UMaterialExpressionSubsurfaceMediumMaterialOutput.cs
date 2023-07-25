#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Materials/MaterialExpressionSubsurfaceMediumMaterialOutput.h")]
///<summary>Material output expression for setting the mean free path and scattering distribution properties of subsurface profile (for the Path Tracer Only).</summary>
public partial class UMaterialExpressionSubsurfaceMediumMaterialOutput : UMaterialExpressionCustomOutput {
// MaterialExpressionSubsurfaceMediumMaterialOutput
	public FExpressionInput MeanFreePath;
	public FExpressionInput ScatteringDistribution;
}
