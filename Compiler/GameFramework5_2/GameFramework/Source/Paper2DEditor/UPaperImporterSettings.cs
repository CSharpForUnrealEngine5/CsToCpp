#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PaperImporterSettings.h")]
///<summary>Implements the settings for imported Paper2D assets, such as sprite sheet textures.</summary>
public partial class UPaperImporterSettings : UObject {
// PaperImporterSettings
	public bool bPickBestMaterialWhenCreatingSprites;
	public bool bPickBestMaterialWhenCreatingTileMaps;
	public bool bAnalysisCanUseOpaque;
	public float DefaultPixelsPerUnrealUnit;
	public TArray<string> NormalMapTextureSuffixes;
	public TArray<string> BaseMapTextureSuffixes;
	public TextureGroup DefaultSpriteTextureGroup;
	public bool bOverrideTextureCompression;
	public TextureCompressionSettings DefaultSpriteTextureCompression;
	public FSoftObjectPath UnlitDefaultMaskedMaterialName;
	public FSoftObjectPath UnlitDefaultTranslucentMaterialName;
	public FSoftObjectPath UnlitDefaultOpaqueMaterialName;
	public FSoftObjectPath LitDefaultMaskedMaterialName;
	public FSoftObjectPath LitDefaultTranslucentMaterialName;
	public FSoftObjectPath LitDefaultOpaqueMaterialName;
}
