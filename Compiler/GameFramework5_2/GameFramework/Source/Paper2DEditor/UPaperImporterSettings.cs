#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Implements the settings for imported Paper2D assets, such as sprite sheet textures.</summary>
[CppInclude("PaperImporterSettings.h")]
public partial class UPaperImporterSettings : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Should the source texture be scanned when creating new sprites to determine the appropriate material? (if false, the Default Masked Material is always used)</summary>
	public bool bPickBestMaterialWhenCreatingSprites;
	///<summary>Should the source texture be scanned when creating new tile maps (from a tile set or via importing) to determine the appropriate material? (if false, the Default Masked Material is always used)</summary>
	public bool bPickBestMaterialWhenCreatingTileMaps;
	///<summary>Can opaque materials be applied as part of the &#39;best material&#39; analysis?</summary>
	public bool bAnalysisCanUseOpaque;
	///<summary>The default scaling factor between pixels and Unreal units (cm) to use for newly created sprite assets (e.g., 0.64 would make a 64 pixel wide sprite take up 100 cm)</summary>
	public float DefaultPixelsPerUnrealUnit;
	///<summary>A list of default suffixes to use when looking for associated normal maps while importing sprites or creating sprites from textures</summary>
	public TArray<string> NormalMapTextureSuffixes;
	///<summary>The default suffix to remove (if present) from a texture name before looking for an associated normal map using NormalMapTextureSuffixes</summary>
	public TArray<string> BaseMapTextureSuffixes;
	///<summary>The default texture group for imported sprite textures, tile sheets, etc... (typically set to UI for &#39;modern 2D&#39; or 2D pixels for &#39;retro 2D&#39;)</summary>
	public TextureGroup DefaultSpriteTextureGroup;
	///<summary>Should texture compression settings be overridden on imported sprite textures, tile sheets, etc...?</summary>
	public bool bOverrideTextureCompression;
	///<summary>Compression settings to use when building the texture.</summary>
	public TextureCompressionSettings DefaultSpriteTextureCompression;
	///<summary>The unlit default masked material for newly created sprites (masked means binary opacity: things are either opaque or see-thru, with nothing in between)</summary>
	public FSoftObjectPath UnlitDefaultMaskedMaterialName;
	///<summary>The unlit default translucent material for newly created sprites (translucent means smooth opacity which can vary continuously from 0..1, but translucent rendering is more expensive that opaque or masked rendering and has different sorting rules)</summary>
	public FSoftObjectPath UnlitDefaultTranslucentMaterialName;
	///<summary>The unlit default opaque material for newly created sprites</summary>
	public FSoftObjectPath UnlitDefaultOpaqueMaterialName;
	///<summary>The lit default masked material for newly created sprites (masked means binary opacity: things are either opaque or see-thru, with nothing in between)</summary>
	public FSoftObjectPath LitDefaultMaskedMaterialName;
	///<summary>The lit default translucent material for newly created sprites (translucent means smooth opacity which can vary continuously from 0..1, but translucent rendering is more expensive that opaque or masked rendering and has different sorting rules)</summary>
	public FSoftObjectPath LitDefaultTranslucentMaterialName;
	///<summary>The lit default opaque material for newly created sprites</summary>
	public FSoftObjectPath LitDefaultOpaqueMaterialName;
}
