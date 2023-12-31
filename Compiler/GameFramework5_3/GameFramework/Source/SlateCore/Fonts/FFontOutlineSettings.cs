namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Settings for applying an outline to a font</summary>
[CppInclude("Fonts/SlateFontInfo.h")]
public partial struct FFontOutlineSettings {
	public int OutlineSize;
	public bool bSeparateFillAlpha;
	public bool bApplyOutlineToDropShadows;
	public UObject OutlineMaterial;
	public FLinearColor OutlineColor;
}
