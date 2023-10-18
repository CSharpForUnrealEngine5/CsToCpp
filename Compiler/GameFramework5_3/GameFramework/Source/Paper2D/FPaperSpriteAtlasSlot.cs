namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PaperSpriteAtlas.h")]
public partial struct FPaperSpriteAtlasSlot {
	public TSoftObjectPtr<UPaperSprite> SpriteRef;
	public int AtlasIndex;
	public int X;
	public int Y;
	public int Width;
	public int Height;
}
