namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("TextureImportSettings.h")]
public partial class UTextureImportSettings : UDeveloperSettings {
	public static UClass StaticClass() {return default;}
	///<summary>Automatically enable the &#39;Virtual Texture Streaming&#39; texture setting for textures larger than or equal to this size. This setting will not affect existing textures in the project.</summary>
	public int AutoVTSize;
	///<summary>NormalizeNormals makes more correct normals in mip maps; it is recommended, but can be turned off to maintain legacy behavior. This setting is applied to newly imported textures, it does not affect existing textures in the project.</summary>
	public bool bEnableNormalizeNormals;
	///<summary>Use the fast mip filter on new textures; it is recommended, but can be turned off to maintain legacy behavior. This setting is applied to newly imported textures, it does not affect existing textures in the project.</summary>
	public bool bEnableFastMipFilter;
	///<summary>Optionally use HDRCompressed (BC6H), or 32-bit adaptively, instead of HDR (RGBA16F) for floating point textures.  This setting is applied to newly imported textures, it does not affect existing textures in the project.</summary>
	public ETextureImportFloatingPointFormat CompressedFormatForFloatTextures;
}
