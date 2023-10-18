namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Groups together a set of sprites that will try to share the same texture atlas (allowing them to be combined into a single draw call)</summary>
[CppInclude("PaperSpriteAtlas.h")]
public partial class UPaperSpriteAtlas : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Description of this atlas, which shows up in the content browser tooltip</summary>
	public string AtlasDescription;
	///<summary>Maximum atlas page width (single pages might be smaller)</summary>
	public int MaxWidth;
	///<summary>Maximum atlas page height (single pages might be smaller)</summary>
	public int MaxHeight;
	///<summary>Maximum atlas page height (single pages might be smaller)</summary>
	public int MipCount;
	///<summary>The type of padding performed on this atlas</summary>
	public EPaperSpriteAtlasPadding PaddingType;
	///<summary>The number of pixels of padding</summary>
	public int Padding;
	///<summary>Compression settings to use on atlas texture</summary>
	public TextureCompressionSettings CompressionSettings;
	///<summary>Texture filtering mode when sampling these textures</summary>
	public TextureFilter Filter;
	///<summary>List of generated atlas textures</summary>
	public TArray<UTexture> GeneratedTextures;
	///<summary>The GUID of the atlas group, used to match up sprites that belong to this group even thru atlas renames</summary>
	public FGuid AtlasGUID;
	///<summary>Slots in the atlas</summary>
	public bool bRebuildAtlas;
	///<summary>Slots in the atlas</summary>
	public TArray<FPaperSpriteAtlasSlot> AtlasSlots;
	///<summary>Track the number of incremental builds</summary>
	public int NumIncrementalBuilds;
	///<summary>Values used when building this atlas</summary>
	public int BuiltWidth;
	///<summary>BuiltHeight</summary>
	public int BuiltHeight;
	///<summary>BuiltPadding</summary>
	public int BuiltPadding;
}
