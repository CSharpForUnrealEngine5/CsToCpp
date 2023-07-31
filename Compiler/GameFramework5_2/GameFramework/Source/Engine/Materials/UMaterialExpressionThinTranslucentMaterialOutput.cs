#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Material output expression for setting absorption properties of thin translucent materials.</summary>
[CppInclude("Materials/MaterialExpressionThinTranslucentMaterialOutput.h")]
public partial class UMaterialExpressionThinTranslucentMaterialOutput : UMaterialExpressionCustomOutput {
	///<summary>Input for the transmittance color for a view perpendicular to the surface. Valid range is [0,1].</summary>
	public FExpressionInput TransmittanceColor;
}
