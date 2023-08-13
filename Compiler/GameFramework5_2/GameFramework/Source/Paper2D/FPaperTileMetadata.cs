namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Information about a single tile in a tile set</summary>
[CppInclude("PaperTileSet.h")]
public partial struct FPaperTileMetadata {
	public string UserDataName;
	public FSpriteGeometryCollection CollisionData;
	public byte TerrainMembership;
}
