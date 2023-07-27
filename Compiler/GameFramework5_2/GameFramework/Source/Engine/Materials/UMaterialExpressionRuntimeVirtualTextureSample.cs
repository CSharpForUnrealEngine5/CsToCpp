#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Materials/MaterialExpressionRuntimeVirtualTextureSample.h")]
///<summary>Material expression for sampling from a runtime virtual texture.</summary>
public partial class UMaterialExpressionRuntimeVirtualTextureSample : UMaterialExpression {
// MaterialExpressionRuntimeVirtualTextureSample
	public FExpressionInput Coordinates;
	public FExpressionInput WorldPosition;
	public FExpressionInput MipValue;
	public URuntimeVirtualTexture VirtualTexture;
	public ERuntimeVirtualTextureMaterialType MaterialType;
	public bool bSinglePhysicalSpace;
	public bool bAdaptive;
	public bool bEnableFeedback;
	public ERuntimeVirtualTextureMipValueMode MipValueMode;
	public ERuntimeVirtualTextureTextureAddressMode TextureAddressMode;
}
