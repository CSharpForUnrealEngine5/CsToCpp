namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Font import options</summary>
[CppInclude("Engine/FontImportOptions.h")]
public partial struct FFontImportOptionsData {
	public string FontName;
	public float Height;
	public bool bEnableAntialiasing;
	public bool bEnableBold;
	public bool bEnableItalic;
	public bool bEnableUnderline;
	public bool bAlphaOnly;
	public EFontImportCharacterSet CharacterSet;
	public string Chars;
	public string UnicodeRange;
	public string CharsFilePath;
	public string CharsFileWildcard;
	public bool bCreatePrintableOnly;
	public bool bIncludeASCIIRange;
	public FLinearColor ForegroundColor;
	public bool bEnableDropShadow;
	public int TexturePageWidth;
	public int TexturePageMaxHeight;
	public int XPadding;
	public int YPadding;
	public int ExtendBoxTop;
	public int ExtendBoxBottom;
	public int ExtendBoxRight;
	public int ExtendBoxLeft;
	public bool bEnableLegacyMode;
	public int Kerning;
	public bool bUseDistanceFieldAlpha;
	public int DistanceFieldScaleFactor;
	public float DistanceFieldScanRadiusScale;
}
