#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("WaveformEditorSlateTypes.h")]
///<summary>Represents the appearance of a Waveform Viewer</summary>
public partial struct FWaveformViewerStyle {
// WaveformViewerStyle
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
