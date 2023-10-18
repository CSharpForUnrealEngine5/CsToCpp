namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A font object, for use by Slate, UMG, and Canvas.</summary>
[CppInclude("Engine/Font.h")]
public partial class UFont : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>What kind of font caching should we use? This controls which options we see</summary>
	public EFontCacheType FontCacheType;
	///<summary>List of characters in the font.  For a MultiFont, this will include all characters in all sub-fonts!  Thus,</summary>
	public TArray<FFontCharacter> Characters;
	///<summary>Textures that store this font&#39;s glyph image data //NOTE: Do not expose this to the editor as it has nasty crash potential</summary>
	public TArray<UTexture2D> Textures;
	///<summary>True if font is &#39;remapped&#39;.  That is, the character array is not a direct mapping to unicode values.  Instead,</summary>
	public int IsRemapped;
	///<summary>Font metrics.</summary>
	public float EmScale;
	///<summary>@todo document</summary>
	public float Ascent;
	///<summary>@todo document</summary>
	public float Descent;
	///<summary>@todo document</summary>
	public float Leading;
	///<summary>Default horizontal spacing between characters when rendering text with this font</summary>
	public int Kerning;
	///<summary>Options used when importing this font</summary>
	public FFontImportOptionsData ImportOptions;
	///<summary>Number of characters in the font, not including multiple instances of the same character (for multi-fonts).</summary>
	public int NumCharacters;
	///<summary>The maximum height of a character in this font.  For multi-fonts, this array will contain a maximum</summary>
	public TArray<int> MaxCharHeight;
	///<summary>Scale to apply to the font.</summary>
	public float ScalingFactor;
	///<summary>The default size of the font used for legacy Canvas APIs that don&#39;t specify a font size</summary>
	public int LegacyFontSize;
	///<summary>The default font name to use for legacy Canvas APIs that don&#39;t specify a font name</summary>
	public FName LegacyFontName;
	///<summary>Embedded composite font data</summary>
	public FCompositeFont CompositeFont;
}
