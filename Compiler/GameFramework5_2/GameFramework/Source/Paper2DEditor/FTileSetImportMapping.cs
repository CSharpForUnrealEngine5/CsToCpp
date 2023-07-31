#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("TileMapAssetImportData.h")]
public partial struct FTileSetImportMapping {
	public string SourceName;
	public TWeakObjectPtr<UPaperTileSet> ImportedTileSet;
	public TWeakObjectPtr<UTexture> ImportedTexture;
}
