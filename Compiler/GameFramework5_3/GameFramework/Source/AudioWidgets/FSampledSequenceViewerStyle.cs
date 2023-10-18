namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Represents the appearance of a Sampled Sequence Viewer</summary>
[CppInclude("AudioWidgetsSlateTypes.h")]
public partial struct FSampledSequenceViewerStyle {
	public FSlateColor SequenceColor;
	public float SequenceLineThickness;
	public FSlateColor MajorGridLineColor;
	public FSlateColor MinorGridLineColor;
	public FSlateColor ZeroCrossingLineColor;
	public float ZeroCrossingLineThickness;
	public float SampleMarkersSize;
	public FSlateColor SequenceBackgroundColor;
	public FSlateBrush BackgroundBrush;
	public float DesiredWidth;
	public float DesiredHeight;
}
