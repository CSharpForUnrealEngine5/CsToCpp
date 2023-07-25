#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("TileMapAssetImportData.h")]
public partial struct FTileSetImportMapping {
// TileSetImportMapping
	public string SourceName;
	public TWeakObjectPtr<UPaperTileSet> ImportedTileSet;
	public TWeakObjectPtr<UTexture> ImportedTexture;
}
