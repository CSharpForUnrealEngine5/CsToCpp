namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MaterialX/MaterialExpressions/MaterialExpressionTextureSampleParameterBlur.h")]
public partial class UMaterialExpressionMaterialXTextureSampleParameterBlur : UMaterialExpressionTextureSampleParameter2D {
	public static UClass StaticClass() {return default;}
	///<summary>The size of the blur kernel, relative to 0-1 UV space.</summary>
	public EMAterialXTextureSampleBlurKernel KernelSize;
	///<summary>Size of the filter when we sample a texture coordinate</summary>
	public float FilterSize;
	///<summary>Offset of the filter when we sample a texture coordinate</summary>
	public float FilterOffset;
	///<summary>Filter to use when we blur a Texture: Gaussian or Box Linear filter</summary>
	public EMaterialXTextureSampleBlurFilter Filter;
}
