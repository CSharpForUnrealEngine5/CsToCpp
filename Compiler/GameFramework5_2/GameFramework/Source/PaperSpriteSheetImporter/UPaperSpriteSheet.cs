#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PaperSpriteSheet.h")]
public partial class UPaperSpriteSheet : UObject {
// PaperSpriteSheet
	public TArray<string> SpriteNames;
	public TArray<TSoftObjectPtr<UPaperSprite>> Sprites;
	public string TextureName;
	public UTexture2D Texture;
	public string NormalMapTextureName;
	public UTexture2D NormalMapTexture;
	public UAssetImportData AssetImportData;
}
