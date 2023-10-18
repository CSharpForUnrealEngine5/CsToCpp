namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Material output expression for writing single layer water volume material properties.</summary>
[CppInclude("Materials/MaterialExpressionSingleLayerWaterMaterialOutput.h")]
public partial class UMaterialExpressionSingleLayerWaterMaterialOutput : UMaterialExpressionCustomOutput {
	public static UClass StaticClass() {return default;}
	///<summary>Input for scattering coefficient describing how light scatter around and is absorbed. Valid range is [0,+inf[. Unit is 1/cm.</summary>
	public FExpressionInput ScatteringCoefficients;
	///<summary>Input for scattering coefficient describing how light bounce is absorbed. Valid range is [0,+inf[. Unit is 1/cm.</summary>
	public FExpressionInput AbsorptionCoefficients;
	///<summary>Input for phase function &#39;g&#39; parameter describing how much forward(g&gt;0) or backward (g&lt;0) light scatter around. Valid range is [-1,1].</summary>
	public FExpressionInput PhaseG;
	///<summary>Input for custom color multiplier for scene color behind water. Can be used for caustics textures etc. Defaults to 1.0. Valid range is [0,+inf[.</summary>
	public FExpressionInput ColorScaleBehindWater;
}
