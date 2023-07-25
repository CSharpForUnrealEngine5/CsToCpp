#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AudioMeterStyle.h")]
///<summary>Represents the appearance of an SAudioMeter</summary>
public partial struct FAudioMeterStyle {
// AudioMeterStyle
	public FSlateBrush MeterValueImage;
	public FSlateBrush BackgroundImage;
	public FSlateBrush MeterBackgroundImage;
	public FSlateBrush MeterValueBackgroundImage;
	public FSlateBrush MeterPeakImage;
	public FVector2D MeterSize;
	public FVector2D MeterPadding;
	public float MeterValuePadding;
	public float PeakValueWidth;
	public FVector2D ValueRangeDb;
	public bool bShowScale;
	public bool bScaleSide;
	public float ScaleHashOffset;
	public float ScaleHashWidth;
	public float ScaleHashHeight;
	public int DecibelsPerHash;
	public FSlateFontInfo Font;
}
