#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Materials/MaterialExpressionSingleLayerWaterMaterialOutput.h")]
///<summary>Material output expression for writing single layer water volume material properties.</summary>
public partial class UMaterialExpressionSingleLayerWaterMaterialOutput : UMaterialExpressionCustomOutput {
// MaterialExpressionSingleLayerWaterMaterialOutput
	public FExpressionInput ScatteringCoefficients;
	public FExpressionInput AbsorptionCoefficients;
	public FExpressionInput PhaseG;
	public FExpressionInput ColorScaleBehindWater;
}
