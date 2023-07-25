#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Fonts/SlateFontInfo.h")]
///<summary>Settings for applying an outline to a font</summary>
public partial struct FFontOutlineSettings {
// FontOutlineSettings
	public int OutlineSize;
	public bool bSeparateFillAlpha;
	public bool bApplyOutlineToDropShadows;
	public UObject OutlineMaterial;
	public FLinearColor OutlineColor;
}
