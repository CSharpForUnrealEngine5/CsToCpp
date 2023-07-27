#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Factories/TextureFactory.h")]
public partial class UTextureFactory : UFactory {
// TextureFactory
	public bool NoCompression;
	public bool NoAlpha;
	public bool bDeferCompression;
	public TextureCompressionSettings CompressionSettings;
	public bool bCreateMaterial;
	public bool bRGBToBaseColor;
	public bool bRGBToEmissive;
	public bool bAlphaToRoughness;
	public bool bAlphaToEmissive;
	public bool bAlphaToOpacity;
	public bool bAlphaToOpacityMask;
	public bool bTwoSided;
	public EBlendMode Blending;
	public EMaterialShadingModel ShadingModel;
	public TextureMipGenSettings MipGenSettings;
	public TextureGroup LODGroup;
	public bool bDoScaleMipsForAlphaCoverage;
	public bool bUseNewMipFilter;
	public FVector4 AlphaCoverageThresholds;
	public bool bPreserveBorder;
	public bool bFlipNormalMapGreenChannel;
	public bool bUsingExistingSettings;
	public bool bUseHashAsGuid;
	public string UdimRegexPattern;
	public ETextureSourceColorSpace ColorSpaceMode;
	public EAppReturnType HDRImportShouldBeLongLatCubeMap;
}
