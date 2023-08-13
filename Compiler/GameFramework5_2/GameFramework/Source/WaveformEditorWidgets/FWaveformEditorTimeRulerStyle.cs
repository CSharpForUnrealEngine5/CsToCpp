namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Represents the appearance of a Waveform Editor Time Ruler</summary>
[CppInclude("WaveformEditorSlateTypes.h")]
public partial struct FWaveformEditorTimeRulerStyle {
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
