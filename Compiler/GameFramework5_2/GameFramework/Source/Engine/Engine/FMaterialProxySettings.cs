#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/MaterialMerging.h")]
public partial struct FMaterialProxySettings {
// MaterialProxySettings
	public byte TextureSizingType;
	public FIntPoint TextureSize;
	public float TargetTexelDensityPerMeter;
	public float MeshMaxScreenSizePercent;
	public double MeshMinDrawDistance;
	public float GutterSpace;
	public float MetallicConstant;
	public float RoughnessConstant;
	public float AnisotropyConstant;
	public float SpecularConstant;
	public float OpacityConstant;
	public float OpacityMaskConstant;
	public float AmbientOcclusionConstant;
	public byte MaterialMergeType;
	public byte BlendMode;
	public bool bAllowTwoSidedMaterial;
	public bool bNormalMap;
	public bool bTangentMap;
	public bool bMetallicMap;
	public bool bRoughnessMap;
	public bool bAnisotropyMap;
	public bool bSpecularMap;
	public bool bEmissiveMap;
	public bool bOpacityMap;
	public bool bOpacityMaskMap;
	public bool bAmbientOcclusionMap;
	public FIntPoint DiffuseTextureSize;
	public FIntPoint NormalTextureSize;
	public FIntPoint TangentTextureSize;
	public FIntPoint MetallicTextureSize;
	public FIntPoint RoughnessTextureSize;
	public FIntPoint AnisotropyTextureSize;
	public FIntPoint SpecularTextureSize;
	public FIntPoint EmissiveTextureSize;
	public FIntPoint OpacityTextureSize;
	public FIntPoint OpacityMaskTextureSize;
	public FIntPoint AmbientOcclusionTextureSize;
}
