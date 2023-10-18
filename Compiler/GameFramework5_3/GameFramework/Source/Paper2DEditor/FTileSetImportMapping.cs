namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("TileMapAssetImportData.h")]
public partial struct FTileSetImportMapping {
	public string SourceName;
	public TWeakObjectPtr<UPaperTileSet> ImportedTileSet;
	public TWeakObjectPtr<UTexture> ImportedTexture;
}
