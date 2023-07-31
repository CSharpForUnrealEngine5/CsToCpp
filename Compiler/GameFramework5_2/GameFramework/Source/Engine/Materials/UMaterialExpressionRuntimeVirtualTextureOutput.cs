#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Material output expression for writing to a runtime virtual texture.</summary>
[CppInclude("Materials/MaterialExpressionRuntimeVirtualTextureOutput.h")]
public partial class UMaterialExpressionRuntimeVirtualTextureOutput : UMaterialExpressionCustomOutput {
	///<summary>Input for Base Color to output to virtual texture.</summary>
	public FExpressionInput BaseColor;
	///<summary>Input for Specular to output to virtual texture.</summary>
	public FExpressionInput Specular;
	///<summary>Input for Roughness to output to virtual texture.</summary>
	public FExpressionInput Roughness;
	///<summary>Input for Surface Normal to output to virtual texture.</summary>
	public FExpressionInput Normal;
	///<summary>Input for World Height to output to virtual texture.</summary>
	public FExpressionInput WorldHeight;
	///<summary>Input for Opacity value used for blending to virtual texture.</summary>
	public FExpressionInput Opacity;
	///<summary>Input for Mask to output to virtual texture.</summary>
	public FExpressionInput Mask;
}
