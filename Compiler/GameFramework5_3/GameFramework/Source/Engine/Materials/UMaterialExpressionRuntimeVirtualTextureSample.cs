namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Material expression for sampling from a runtime virtual texture.</summary>
[CppInclude("Materials/MaterialExpressionRuntimeVirtualTextureSample.h")]
public partial class UMaterialExpressionRuntimeVirtualTextureSample : UMaterialExpression {
	public static UClass StaticClass() {return default;}
	///<summary>Optional UV coordinates input if we want to override standard world position based coordinates.</summary>
	public FExpressionInput Coordinates;
	///<summary>Optional world position input to override the default world position.</summary>
	public FExpressionInput WorldPosition;
	///<summary>Meaning depends on MipValueMode. A single unit is one mip level.</summary>
	public FExpressionInput MipValue;
	///<summary>The virtual texture object to sample.</summary>
	public URuntimeVirtualTexture VirtualTexture;
	///<summary>How to interpret the virtual texture contents. Note that the bound Virtual Texture should have the same setting for sampling to work correctly.</summary>
	public ERuntimeVirtualTextureMaterialType MaterialType;
	///<summary>Enable page table channel packing. Note that the bound Virtual Texture should have the same setting for sampling to work correctly.</summary>
	public bool bSinglePhysicalSpace;
	///<summary>Enable sparse adaptive page tables. Note that the bound Virtual Texture should have valid adaptive virtual texture settings for sampling to work correctly.</summary>
	public bool bAdaptive;
	///<summary>Enable virtual texture feedback.</summary>
	public bool bEnableFeedback;
	///<summary>Defines how the mip level is calculated for the virtual texture lookup.</summary>
	public ERuntimeVirtualTextureMipValueMode MipValueMode;
	///<summary>Defines the texture addressing mode.</summary>
	public ERuntimeVirtualTextureTextureAddressMode TextureAddressMode;
}
