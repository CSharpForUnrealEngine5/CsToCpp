#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Represents the appearance of a Waveform Viewer</summary>
[CppInclude("WaveformEditorSlateTypes.h")]
public partial struct FWaveformViewerStyle {
	public FSlateColor WaveformColor;
	public float WaveformLineThickness;
	public FSlateColor MajorGridLineColor;
	public FSlateColor MinorGridLineColor;
	public FSlateColor ZeroCrossingLineColor;
	public float ZeroCrossingLineThickness;
	public float SampleMarkersSize;
	public FSlateColor WaveformBackgroundColor;
	public FSlateBrush BackgroundBrush;
	public float DesiredWidth;
	public float DesiredHeight;
}
