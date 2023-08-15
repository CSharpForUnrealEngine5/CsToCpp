namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A representation of a font in Slate.</summary>
[CppInclude("Fonts/SlateFontInfo.h")]
public partial struct FSlateFontInfo {
	public UObject FontObject;
	public UObject FontMaterial;
	public FFontOutlineSettings OutlineSettings;
	public FName TypefaceFontName;
	public int Size;
	public int LetterSpacing;
	public float SkewAmount;
	public FName FontName_DEPRECATED;
	public EFontHinting Hinting_DEPRECATED;
}
