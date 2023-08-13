namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Material output expression for writing to a runtime virtual texture.</summary>
[CppInclude("Materials/MaterialExpressionRuntimeVirtualTextureOutput.h")]
public partial class UMaterialExpressionRuntimeVirtualTextureOutput : UMaterialExpressionCustomOutput {
	public static UClass StaticClass() {return default;}
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
