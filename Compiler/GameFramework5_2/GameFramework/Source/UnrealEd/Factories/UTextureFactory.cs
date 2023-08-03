#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Factories/TextureFactory.h")]
public partial class UTextureFactory : UFactory {
	public static UClass StaticClass() {return default;}
	///<summary>NoCompression</summary>
	public bool NoCompression;
	///<summary>If enabled, the texture&#39;s alpha channel will be discarded during compression</summary>
	public bool NoAlpha;
	///<summary>If enabled, compression is deferred until the texture is saved</summary>
	public bool bDeferCompression;
	///<summary>Compression settings for the texture</summary>
	public TextureCompressionSettings CompressionSettings;
	///<summary>If enabled, a material will automatically be created for the texture</summary>
	public bool bCreateMaterial;
	///<summary>If enabled, link the texture to the created material&#39;s base color</summary>
	public bool bRGBToBaseColor;
	///<summary>If enabled, link the texture to the created material&#39;s emissive color</summary>
	public bool bRGBToEmissive;
	///<summary>If enabled, link the texture&#39;s alpha to the created material&#39;s roughness</summary>
	public bool bAlphaToRoughness;
	///<summary>If enabled, link the texture&#39;s alpha to the created material&#39;s emissive color</summary>
	public bool bAlphaToEmissive;
	///<summary>If enabled, link the texture&#39;s alpha to the created material&#39;s opacity</summary>
	public bool bAlphaToOpacity;
	///<summary>If enabled, link the texture&#39;s alpha to the created material&#39;s opacity mask</summary>
	public bool bAlphaToOpacityMask;
	///<summary>If enabled, the created material will be two-sided</summary>
	public bool bTwoSided;
	///<summary>The blend mode of the created material</summary>
	public EBlendMode Blending;
	///<summary>The shading model of the created material</summary>
	public EMaterialShadingModel ShadingModel;
	///<summary>The mip-map generation settings for the texture; Allows customization of the content of the mip-map chain</summary>
	public TextureMipGenSettings MipGenSettings;
	///<summary>The group the texture belongs to</summary>
	public TextureGroup LODGroup;
	///<summary>Whether mip RGBA should be scaled to preserve the number of pixels with Value &gt;= AlphaCoverageThresholds</summary>
	public bool bDoScaleMipsForAlphaCoverage;
	///<summary>Whether to use newer &amp; faster mip generation filter</summary>
	public bool bUseNewMipFilter;
	///<summary>Channel values to compare to when preserving alpha coverage from a mask for mips</summary>
	public FVector4 AlphaCoverageThresholds;
	///<summary>If enabled, preserve the value of border pixels when creating mip-maps</summary>
	public bool bPreserveBorder;
	///<summary>If enabled, the texture&#39;s green channel will be inverted. This is useful for some normal maps</summary>
	public bool bFlipNormalMapGreenChannel;
	///<summary>If enabled, we are using the existing settings for a texture that already existed.</summary>
	public bool bUsingExistingSettings;
	///<summary>If enabled, we are using the texture content hash as the guid.</summary>
	public bool bUseHashAsGuid;
	///<summary>The pattern to use to match UDIM files to indices. Defaults to match a filename that ends with either .1001 or _1001</summary>
	public string UdimRegexPattern;
	///<summary>Mode for how to determine the color space of the source image. Auto will let the factory decide based on header metadata or bit depth. Linear or SRGB will force the color space on the resulting texture.</summary>
	public ETextureSourceColorSpace ColorSpaceMode;
	///<summary>Store YesAll/NoAll responses:</summary>
	public EAppReturnType HDRImportShouldBeLongLatCubeMap;
}
