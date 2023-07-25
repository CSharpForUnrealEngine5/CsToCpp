#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/Font.h")]
///<summary>A font object, for use by Slate, UMG, and Canvas.</summary>
public partial class UFont : UObject {
// Font
	public EFontCacheType FontCacheType;
	public TArray<FFontCharacter> Characters;
	public TArray<UTexture2D> Textures;
	public int IsRemapped;
	public float EmScale;
	public float Ascent;
	public float Descent;
	public float Leading;
	public int Kerning;
	public FFontImportOptionsData ImportOptions;
	public int NumCharacters;
	public TArray<int> MaxCharHeight;
	public float ScalingFactor;
	public int LegacyFontSize;
	public string LegacyFontName;
	public FCompositeFont CompositeFont;
}
