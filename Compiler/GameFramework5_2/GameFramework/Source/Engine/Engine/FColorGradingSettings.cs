#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/Scene.h")]
public partial struct FColorGradingSettings {
	public FColorGradePerRangeSettings Global;
	public FColorGradePerRangeSettings Shadows;
	public FColorGradePerRangeSettings Midtones;
	public FColorGradePerRangeSettings Highlights;
	public float ShadowsMax;
	public float HighlightsMin;
	public float HighlightsMax;
}
