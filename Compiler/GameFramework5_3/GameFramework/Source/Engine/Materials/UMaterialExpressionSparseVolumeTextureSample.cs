namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Material expression for sampling from a runtime virtual texture.</summary>
[CppInclude("Materials/MaterialExpressionSparseVolumeTextureSample.h")]
public partial class UMaterialExpressionSparseVolumeTextureSample : UMaterialExpressionSparseVolumeTextureBase {
	public static UClass StaticClass() {return default;}
	///<summary>3D texture coordinate used to sample the sparse volume texture.</summary>
	public FExpressionInput Coordinates;
	///<summary>Defaults to &#39;SparseVolumeTexture&#39; if not specified</summary>
	public FExpressionInput TextureObject;
	///<summary>Defaults to 0 if not specified</summary>
	public FExpressionInput MipLevel;
	///<summary>Controls where the sampler for this texture lookup will come from.</summary>
	public ESamplerSourceMode SamplerSource;
}
