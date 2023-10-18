namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PaperSpriteSheet.h")]
public partial class UPaperSpriteSheet : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>The names of sprites during import</summary>
	public TArray<string> SpriteNames;
	///<summary>Sprites</summary>
	public TArray<TSoftObjectPtr<UPaperSprite>> Sprites;
	///<summary>The name of the default or diffuse texture during import</summary>
	public string TextureName;
	///<summary>The asset that was created for TextureName</summary>
	public UTexture2D Texture;
	///<summary>The name of the normal map texture during import (if any)</summary>
	public string NormalMapTextureName;
	///<summary>The asset that was created for NormalMapTextureName (if any)</summary>
	public UTexture2D NormalMapTexture;
	///<summary>Import data for this</summary>
	public UAssetImportData AssetImportData;
}
