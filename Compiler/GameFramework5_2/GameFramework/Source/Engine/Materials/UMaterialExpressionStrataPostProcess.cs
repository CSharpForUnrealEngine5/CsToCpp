#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Materials/MaterialExpressionStrata.h")]
public partial class UMaterialExpressionStrataPostProcess : UMaterialExpressionStrataBSDF {
	///<summary>The output color of the post process: it represents a color added over the back buffer, or a color multiplied if the Substrate blend mode is TransmittanceOnly.</summary>
	public FExpressionInput Color;
	///<summary>The coverage of the post process: the more the value is high, the less the back buffer will be visible. Only used if &quot;Output Alpha&quot; is enabled on the root node.</summary>
	public FExpressionInput Opacity;
}
