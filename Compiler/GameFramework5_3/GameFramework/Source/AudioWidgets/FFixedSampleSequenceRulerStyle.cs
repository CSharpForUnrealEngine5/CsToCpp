namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Represents the appearance of a Sampled Sequence Time Ruler</summary>
[CppInclude("AudioWidgetsSlateTypes.h")]
public partial struct FFixedSampleSequenceRulerStyle {
	public float HandleWidth;
	public FSlateColor HandleColor;
	public FSlateBrush HandleBrush;
	public FSlateColor TicksColor;
	public FSlateColor TicksTextColor;
	public FSlateFontInfo TicksTextFont;
	public float TicksTextOffset;
	public FSlateColor BackgroundColor;
	public FSlateBrush BackgroundBrush;
	public float DesiredWidth;
	public float DesiredHeight;
}
