#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Fonts/SlateFontInfo.h")]
///<summary>A representation of a font in Slate.</summary>
public partial struct FSlateFontInfo {
// SlateFontInfo
	public UObject FontObject;
	public UObject FontMaterial;
	public FFontOutlineSettings OutlineSettings;
	public string TypefaceFontName;
	public int Size;
	public int LetterSpacing;
	public float SkewAmount;
	public string FontName_DEPRECATED;
	public EFontHinting Hinting_DEPRECATED;
}
