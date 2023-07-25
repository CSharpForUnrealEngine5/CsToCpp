#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PaperSpriteAtlas.h")]
///<summary>Groups together a set of sprites that will try to share the same texture atlas (allowing them to be combined into a single draw call)</summary>
public partial class UPaperSpriteAtlas : UObject {
// PaperSpriteAtlas
	public string AtlasDescription;
	public int MaxWidth;
	public int MaxHeight;
	public int MipCount;
	public EPaperSpriteAtlasPadding PaddingType;
	public int Padding;
	public byte CompressionSettings;
	public byte Filter;
	public TArray<UTexture> GeneratedTextures;
	public FGuid AtlasGUID;
	public bool bRebuildAtlas;
	public TArray<FPaperSpriteAtlasSlot> AtlasSlots;
	public int NumIncrementalBuilds;
	public int BuiltWidth;
	public int BuiltHeight;
	public int BuiltPadding;
}
