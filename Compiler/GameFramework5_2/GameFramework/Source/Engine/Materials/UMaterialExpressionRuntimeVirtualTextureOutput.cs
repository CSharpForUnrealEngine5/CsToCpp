#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Materials/MaterialExpressionRuntimeVirtualTextureOutput.h")]
///<summary>Material output expression for writing to a runtime virtual texture.</summary>
public partial class UMaterialExpressionRuntimeVirtualTextureOutput : UMaterialExpressionCustomOutput {
// MaterialExpressionRuntimeVirtualTextureOutput
	public FExpressionInput BaseColor;
	public FExpressionInput Specular;
	public FExpressionInput Roughness;
	public FExpressionInput Normal;
	public FExpressionInput WorldHeight;
	public FExpressionInput Opacity;
	public FExpressionInput Mask;
}
